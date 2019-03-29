using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;


//************************************************************************//
// This project makes an extremely simple server to connect to the other  //
// traffic light clients.  Because of the personal firewall on the lab    //
// computers being switched on, the server cannot use a listening socket  //
// accept incomming connections.  So the server to actually connects to a //
// sort of proxy (running in my office) that accepts the incomming        //
// connection.                                                            //    
// By Nigel.                                                              //
//                                                                        //
// Please use this code, sich as it is,  for any eduactional or non       //
// profit making research porposes on the conditions that.                //
//                                                                        //
// 1.    You may only use it for educational and related research         //
//      pusposes.                                                         //
//                                                                        //
// 2.   You leave my name on it.                                          //
//                                                                        //
// 3.   You correct at least 10% of the typig and spekking mistskes.      //
//                                                                        //
// © Nigel Barlow nigel@soc.plymouth.ac.uk 2018                           //
//************************************************************************//

namespace TrafficLightServer
{

    //New wrapper class.
    public delegate void UI_UpdateHandler(String message);

    public partial class FormServer : Form
    {
        public FormServer()
        {
            InitializeComponent();
            //all car counters are reset to 0 here to prevent small bugs
            Thread reset3 = new Thread(ResetSet2);
            reset3.Start();
            Thread reset4 = new Thread(ResetSet1);
            reset4.Start();
        }


        //******************************************************//
        // Nigel Networking attributes.                         //
        //******************************************************//
        private int              serverPort       = 5000;
        private int              bufferSize       = 200;
        private TcpClient        socketClient     = null;
        private String           serverName       = "eeyore.fost.plymouth.ac.uk";  //A computer in my office.
        private NetworkStream    connectionStream = null;
        private BinaryReader     inStream         = null;
        private BinaryWriter     outStream        = null;
        private ThreadConnection threadConnection = null;

        //so is an object which allows us to edit the car counters in threads
        DataTransfer so = new DataTransfer();

        //traffic light objects here to help us edit car counters when in threads
        TrafficLight topLeftNorthTrafficLight = new TrafficLight();
        TrafficLight topLeftSouthTrafficLight = new TrafficLight();
        TrafficLight topLeftWestTrafficLight = new TrafficLight();
        TrafficLight topLeftEastTrafficLight = new TrafficLight();

        TrafficLight bottomLeftNorthTrafficLight = new TrafficLight();
        TrafficLight bottomLeftSouthTrafficLight = new TrafficLight();
        TrafficLight bottomLeftWestTrafficLight = new TrafficLight();
        TrafficLight bottomLeftEastTrafficLight = new TrafficLight();

        TrafficLight topRightNorthTrafficLight = new TrafficLight();
        TrafficLight topRightSouthTrafficLight = new TrafficLight();
        TrafficLight topRightWestTrafficLight = new TrafficLight();
        TrafficLight topRightEastTrafficLight = new TrafficLight();

        TrafficLight bottomRightNorthTrafficLight = new TrafficLight();
        TrafficLight bottomRightSouthTrafficLight = new TrafficLight();
        TrafficLight bottomRightWestTrafficLight = new TrafficLight();
        TrafficLight bottomRightEastTrafficLight = new TrafficLight();

        //timer is initialized to 0
        int timerTickTockCount = 0;

        //*******************************************************************//
        // This one is needed so that we can post messages back to the form's//
        // thread and don't violate C#'s threading rule that says you can    //
        // only touch the UI components from the form's thread.              //
        //*******************************************************************//
        private SynchronizationContext uiContext = null;

        //*********************************************************************//
        // Form load.  Display an IP. Or a series of IPs.                      //                               
        //*********************************************************************//
        private void Form1_Load(object sender, EventArgs e)
        {
            //******************************************************************//
            //All this to find out IP number.                                   //
            //******************************************************************//
            IPHostEntry localHostInfo = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());

            listBoxOutput.Items.Add("You may have many IP numbers.");
            listBoxOutput.Items.Add("In the Plymouth labs, use the IP that looks like an IP4 number");
            listBoxOutput.Items.Add("something like 10.xx.xx.xx.");
            listBoxOutput.Items.Add("If at home using a VPN use the IP4 number that starts");
            listBoxOutput.Items.Add("something like 141.163.xx.xx");
            listBoxOutput.Items.Add(" ");


            foreach (IPAddress address in localHostInfo.AddressList)
                listBoxOutput.Items.Add(address.ToString());


            //******************************************************************//
            // Get the SynchronizationContext for the current thread (the form's//
            // thread).                                                         //
            //******************************************************************//
            uiContext = SynchronizationContext.Current;
            if (uiContext == null)
                listBoxOutput.Items.Add("No context for this thread");
            else
                listBoxOutput.Items.Add("We got a context");
 
        }
        //*********************************************************************//
        // The OnClick for the "connect"command button.  Create a new client   //
        // socket.   Much of this code is exception processing.                //
        //*********************************************************************//
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                socketClient = new TcpClient(serverName, serverPort);
            }
            catch (Exception ee)
            {
                listBoxOutput.Items.Add("Error in connecting to server");     //Console is a sealed object; we
                listBoxOutput.Items.Add(ee.Message);				 	       //can't make it, we can just access
                labelStatus.Text = "Error " + ee.Message;
                labelStatus.BackColor = Color.Red;
            }

            if (socketClient == null)
            {
                listBoxOutput.Items.Add("Socket not connected");

            }
            else
            {

                //**************************************************//
                // Make some streams.  They have rather more        //
                // capabilities than just a socket.  With this type //
                // of socket, we can't read from it and write to it //
                // directly.                                        //
                //**************************************************//
                connectionStream = socketClient.GetStream();
                inStream         = new BinaryReader(connectionStream);
                outStream        = new BinaryWriter(connectionStream);

                listBoxOutput.Items.Add("Socket connected to " + serverName);

                labelStatus.BackColor = Color.Green;
                labelStatus.Text = "Connected to " + serverName;
                //start the timer
                timerTickTock.Start();
                //**********************************************************//
                // Discale connect button (we can only connect once) and    //
                // enable other components.                                 //
                //**********************************************************//
                buttonConnect.Enabled       = false;
                comboBoxLightColour.Enabled = true;

                //***********************************************************//
                //We have now accepted a connection.                         //
                //                                                           //
                //There are several ways to do this next bit.   Here I make a//
                //network stream and use it to create two other streams, an  //
                //input and an output stream.   Life gets easier at that     //
                //point.                                                     //
                //***********************************************************//
                threadConnection = new ThreadConnection(uiContext, socketClient, this);
  
                //***********************************************************//
                // Create a new Thread to manage the connection that receives//
                // data.  If you are a Java programmer, this looks like a    //
                // load of hokum cokum..                                     //
                //***********************************************************//
                Thread threadRunner = new Thread(new ThreadStart(threadConnection.run));
                threadRunner.Start();

                Console.WriteLine("Created new connection class");
                //start top left north traffic light on green
                comboBoxLightColour.SelectedIndex = 2;
            }
        }

        //*********************************************************************//
        // The item in the combo box has been changed.  Transmit it.           // 
        //*********************************************************************//
        /// <summary>
        /// when changing the comboBox to different colours also change the timer to the corresponding number to give the correct amount of time on each colour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxLightColour_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBoxLightColour.SelectedItem == "Green")
            {
                timerTickTockCount = 1;
            }
            else if ((string)comboBoxLightColour.SelectedItem == "Amber")
            {
                timerTickTockCount = 41;
            }
            else if ((string)comboBoxLightColour.SelectedItem == "Red")
            {
                timerTickTockCount = 56;
            }
            else if ((string)comboBoxLightColour.SelectedItem == "Red & Amber")
            {
                timerTickTockCount = 91;
            }
            //send message to update the traffic lights in all the clients
            SendMessage((String)comboBoxLightColour.SelectedItem);
        }
        /// <summary>
        /// send message to the traffic lights display in the clients (either to update the car counters or traffic light colours)
        /// </summary>
        /// <param name="colour"></param>
        private void SendMessage(String colour)
        {
            String toSendIP = textBoxLightIP.Text;
            sendString(colour, toSendIP);
        }
        //**********************************************************************//
        // Send a string to the IP you give.  The string and IP are bundled up  //
        // into one of there rather quirky Nigel style packets.                 // 
        //                                                                      //
        // This uses the pre-defined stream outStream.  If this strean doesn't  //
        // exist then this method will bomb.                                    //
        //                                                                      //
        // It also does the networking synchronously, in the form's main        //
        // Thread.  This is not good practise; all networking should really be  //
        // asynchronous.                                                        //
        //**********************************************************************//
        private void sendString(String stringToSend, String sendToIP)
        {

            try
            {
                byte[] packet = new byte[bufferSize];
                String[] ipStrings = sendToIP.Split('.'); //Split with . as separator

                packet[0] = Byte.Parse(ipStrings[0]);
                packet[1] = Byte.Parse(ipStrings[1]);   //Think about this.  It assumes the user
                packet[2] = Byte.Parse(ipStrings[2]);   //has entered the IP corrrectly, and 
                packet[3] = Byte.Parse(ipStrings[3]);   //sends the numbers without the bytes.

                int bufferIndex = 4;                    //Start assembling message

                //**************************************************************//
                // Turn the string into an array of characters.                 //
                //**************************************************************//
                int length   = stringToSend.Length;
                char[] chars = stringToSend.ToCharArray();


                //**************************************************************//
                // Then turn each character into a byte and copy into my packet.//
                //**************************************************************//
                for (int i = 0; i < length; i++)
                {
                    byte b = (byte)chars[i];
                    packet[bufferIndex] = b;
                    bufferIndex++;
                }

                packet[bufferIndex] = 0;    //End of packet (even though it is always 200 bytes)

                outStream.Write(packet, 0, bufferSize);
            }
            catch (Exception doh)
            {
                listBoxOutput.Items.Add("An error occurred: " + doh.Message);
            }

        }
        /// <summary>
        /// the timer method changes the lights based on the timer counter, and adds cars automatically to the outside 8 traffic light rows. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerTickTock_Tick(object sender, EventArgs e)
        {
            //change the traffic lights based on the timer
            if (timerTickTockCount <= 40)
            {
                comboBoxLightColour.SelectedItem = "Green";              
            }
            else if (timerTickTockCount <= 55)
            {
                comboBoxLightColour.SelectedItem = "Amber";           
            }
            else if (timerTickTockCount <= 90)
            {
                comboBoxLightColour.SelectedItem = "Red";           
            }
            else if (timerTickTockCount <= 105)
            {
                comboBoxLightColour.SelectedItem = "Red & Amber";              
            }
            else
            {
                ResetTimer();
            }
            
            //if the timer is divisible by 10, aka after 10 ticks add a car if the light is on the correct colour, and check if it needs reseting.
            if (timerTickTockCount % 10 == 0)
            {
                //if the traffic light is not green add car
                if(comboBoxLightColour.SelectedIndex != 2)
                {                  
                    Thread update1 = new Thread(UpdateSet1);
                    update1.Start();
                }
                else if (comboBoxLightColour.SelectedIndex != 0)
                {
                    Thread update2 = new Thread(UpdateSet2);
                    update2.Start();
                }
                //if traffic light is green reset car counters to 0
                if(comboBoxLightColour.SelectedIndex == 0)
                {
                    Thread reset2 = new Thread(ResetSet2);
                    reset2.Start();
                }
                else if (comboBoxLightColour.SelectedIndex == 2)
                {
                    Thread reset1 = new Thread(ResetSet1);
                    reset1.Start();
                }           
                Thread updateCounters = new Thread(UpdateCounters);
                updateCounters.Start();
            }
            //if the counter checkers in the class DataTransfer returns the light colour green or if any of the car counters are greater then 9 then change the traffic light to green
            if (so.getLightColour() == "Green" || so.getTopLeftNorthCarCounter() > 9 || so.getTopLeftSouthCarCounter() > 9 || so.getbottomLeftNorthCarCounter() > 9 || so.getbottomLeftSouthCarCounter() > 9 || so.gettopRightNorthCarCounter() > 9 || so.gettopRightSouthCarCounter() > 9 || so.getBottomRightNorthCarCounter() > 9 || so.getBottomRightSouthCarCounter() > 9)
            {
                comboBoxLightColour.SelectedIndex = 2;
            }
            else if (so.getLightColour() == "Red" || so.getTopLeftWestCarCounter() > 9 || so.getTopLeftEastCarCounter() > 9 || so.getbottomLeftWestCarCounter() > 9 || so.getbottomLeftEastCarCounter() > 9 || so.gettopRightWestCarCounter() > 9 || so.gettopRightEastCarCounter() > 9 || so.getBottomRightWestCarCounter() > 9 || so.getBottomRightEastCarCounter() > 9)
            {
                comboBoxLightColour.SelectedIndex = 0;
            }
            timerTickTockCount += 1;
        }
        /// <summary>
        /// send all the cars to random directions available to them and then reset the queues down to 0 when the light is green.
        /// </summary>
        private void ResetSet2()
        {
            //RandomDirection requres the number of cars in the queue, the direction the queue is from and the grid it is on.
            //1 = north, 2 = east, 3 = south, 4 = west
            RandomDirection(so.getTopLeftWestCarCounter(), 4, "top left");
            so.resetTopLeftWestCarCounter();
            RandomDirection(so.gettopRightEastCarCounter(), 2, "top right");
            so.resetTopLeftEastCarCounter();
            RandomDirection(so.getbottomLeftWestCarCounter(), 4, "bottom left");
            so.resetbottomLeftWestCarCounter();
            RandomDirection(so.getbottomLeftEastCarCounter(), 2, "bottom left");
            so.resetbottomLeftEastCarCounter();
            RandomDirection(so.gettopRightEastCarCounter(), 2, "top right");
            so.resettopRightEastCarCounter();
            RandomDirection(so.gettopRightWestCarCounter(), 4, "top right");
            so.resettopRightWestCarCounter();
            RandomDirection(so.getBottomRightWestCarCounter(), 4, "bottom right");
            so.resetBottomRightWestCarCounter();
            RandomDirection(so.getBottomRightEastCarCounter(), 2, "bottom right");
            so.resetBottomRightEastCarCounter();
        }
        /// <summary>
        /// resets the counters for the other set of traffic lights by first directing the cars randomly and then reseting down to 0.
        /// </summary>
        private void ResetSet1()
        {
            RandomDirection(so.getTopLeftNorthCarCounter(), 1, "top left");
            so.resetTopLeftNorthCarCounter();
            RandomDirection(so.getTopLeftSouthCarCounter(), 3, "top left");
            so.resetTopLeftSouthCarCounter();
            RandomDirection(so.getbottomLeftNorthCarCounter(), 1, "bottom left");
            so.resetbottomLeftNorthCarCounter();
            RandomDirection(so.getbottomLeftSouthCarCounter(), 3, "bottom left");
            so.resetbottomLeftSouthCarCounter();
            RandomDirection(so.gettopRightNorthCarCounter(), 1, "top right");
            so.resettopRightNorthCarCounter();
            RandomDirection(so.gettopRightSouthCarCounter(), 3, "top right");
            so.resettopRightSouthCarCounter();
            RandomDirection(so.getBottomRightNorthCarCounter(), 1, "bottom right");
            so.resetBottomRightNorthCarCounter();
            RandomDirection(so.getBottomRightSouthCarCounter(), 3, "bottom right");
            so.resetBottomRightSouthCarCounter();
        }
        /// <summary>
        /// increments the 4 outer traffic lights that are not on green
        /// </summary>
        private void UpdateSet1()
        {
            so.incrementTopLeftNorth();
            so.incrementBottomLeftSouth();
            so.incrementTopRightNorth();
            so.incrementbottomRightSouth();
        }
        /// <summary>
        /// increments the other 4 outer traffic lights when they are not on green
        /// </summary>
        private void UpdateSet2()
        {
            so.incrementTopLeftWest();
            so.incrementBottomLeftWest();
            so.incrementTopRightEast();
            so.incrementbottomRightEast();
        }
        /// <summary>
        /// sends the car counters to the clients as a string separated by commas, which split string is used by the clients to get their car counters.
        /// </summary>
        private void UpdateCounters()
        {
            string stringToSend = "Car Counter ," + so.getTopLeftSouthCarCounter() + "," + so.getTopLeftEastCarCounter() + "," + so.getTopLeftNorthCarCounter() + "," + so.getTopLeftWestCarCounter() + "," + so.getbottomLeftNorthCarCounter() + "," + so.getbottomLeftSouthCarCounter() + "," + so.getbottomLeftWestCarCounter() + "," + so.getbottomLeftEastCarCounter() + "," + so.gettopRightNorthCarCounter() + "," + so.gettopRightSouthCarCounter() + "," + so.gettopRightWestCarCounter() + "," + so.gettopRightEastCarCounter() + "," + so.getBottomRightNorthCarCounter() + "," + so.getBottomRightSouthCarCounter() + "," + so.getBottomRightWestCarCounter() + "," + so.getBottomRightEastCarCounter();
            SendMessage(stringToSend);
        }

        /// <summary>
        /// takes in the number of cars in a queue, the direction it came from, and which grid it is on, and sends the car on one of the other 3 directions randomly chosen
        /// </summary>
        /// <param name="carCounter"></param>
        /// <param name="direction"></param>
        /// <param name="grid"></param>
        private void RandomDirection(int carCounter, int direction, string grid)
        {
            //for all cars in the queue
            for (int i = 1; i <= carCounter; i++)
            {
                int D = 0;
                Random rand = new Random();
                //randomly choose new direction
                do
                {
                    D = rand.Next(1, 5);
                } while (D == direction);
                //check which grid it is on
                if (grid == "top left")
                {
                    //check if it is being send to the inner 8 traffic lights, if so increment appropriately
                    if (D == 2)
                    {
                        so.incrementTopRightWest();
                    }
                    else if (D == 3)
                    {
                        so.incrementBottomLeftNorth();
                    }
                }
                else if (grid == "top right")
                {
                    if (D == 3)
                    {
                        so.incrementbottomRightNorth();
                    }
                    else if (D == 4)
                    {
                        so.incrementTopLeftEast();
                    }
                }
                else if (grid == "bottom left")
                {
                    if (D == 1)
                    {
                        so.incrementTopLeftSouth();
                    }
                    else if (D == 2)
                    {
                        so.incrementbottomRightWest();
                    }
                }
                else if (grid == "bottom right")
                {
                    if (D == 1)
                    {
                        so.incrementTopRightSouth();
                    }
                    else if (D == 4)
                    {
                        so.incrementBottomLeftEast();
                    }
                }
                          
            }
        }
        

        /// <summary>
        /// reset the timer down to 0
        /// </summary>
        private void ResetTimer()
        {
            timerTickTock.Stop();
            timerTickTockCount = 0;
            timerTickTock.Start();
        }

        //*********************************************************************//
        // Message was posted back to us.  This is to get over the C# threading//
        // rules whereby we can only touch the UI components from the thread   //
        // that created them, which is the form's main thread.                 // 
        //*********************************************************************//
        /// <summary>
        /// handles when the client sends the server a car
        /// </summary>
        /// <param name="received"></param>
        public void MessageReceived(Object received)
        {
            String message = (String)received;
            if(message.Contains("Car"))
            {
                //split message into parts
                string[] splitString;
                char[] deliminter = { ',' };
                splitString = message.Split(deliminter);

                //code below is repeated with slightly different if statements and counter increments
                //if the message was sent by the top left grid north traffic light then increment that counter and check if the light needs to be changed
                if (splitString[1] == "top left north")
                {
                    //if the traffic light is not green then increment and check if light needs to be changed
                    if (comboBoxLightColour.SelectedIndex != 2)
                    {
                        topLeftNorthTrafficLight.setRef(so);
                        Thread northThread = new Thread(new ThreadStart(topLeftNorthTrafficLight.runTopLeftNorth));
                        northThread.Start();
                        listBoxOutput.Items.Add(splitString[1] + " sent car");                         
                        if (so.getLightColour() == "Green")
                        {
                            comboBoxLightColour.SelectedIndex = 2;
                            ResetTimer();
                        }
                    }
                    //if light is green send green to make sure no car counters are incremented when they shouldn't be
                    else
                    {
                        SendMessage("Green");
                    }
                }
                else if (splitString[1] == "top left west")
                {
                    if(comboBoxLightColour.SelectedIndex != 0)
                    {
                        topLeftWestTrafficLight.setRef(so);
                        Thread westThread = new Thread(new ThreadStart(topLeftWestTrafficLight.runTopLeftWest));
                        westThread.Start();
                        listBoxOutput.Items.Add(splitString[1] + "sent car");
                        if(so.getLightColour() == "Red")
                        {
                            comboBoxLightColour.SelectedIndex = 0;
                            timerTickTockCount = 56;
                        }
                    }
                    else
                    {
                        SendMessage("Red");
                    }
                }
                else if(splitString[1] == "bottom left west")
                {
                    if (comboBoxLightColour.SelectedIndex != 0)
                    {
                        bottomLeftWestTrafficLight.setRef(so);
                        Thread westThread = new Thread(new ThreadStart(so.incrementBottomLeftWest));
                        westThread.Start();
                        listBoxOutput.Items.Add(splitString[1] + "sent car");
                        if (so.getLightColour() == "Red")
                        {
                            comboBoxLightColour.SelectedIndex = 0;
                            timerTickTockCount = 56;
                        }
                    }
                    else
                    {
                        SendMessage("Red");
                    }
                }
                else if(splitString[1] == "bottom left south")
                {
                    if (comboBoxLightColour.SelectedIndex != 2)
                    {
                        bottomLeftSouthTrafficLight.setRef(so);
                        Thread northThread = new Thread(new ThreadStart(so.incrementBottomLeftSouth));
                        northThread.Start();
                        listBoxOutput.Items.Add(splitString[1] + " sent car");
                        if (so.getLightColour() == "Green")
                        {
                            comboBoxLightColour.SelectedIndex = 2;
                            ResetTimer();
                        }
                    }
                    else
                    {
                        SendMessage("Green");
                    }
                }
                else if(splitString[1] == "top right north")
                {
                    if (comboBoxLightColour.SelectedIndex != 2)
                    {
                        topRightNorthTrafficLight.setRef(so);
                        Thread northThread = new Thread(new ThreadStart(so.incrementTopRightNorth));
                        northThread.Start();
                        listBoxOutput.Items.Add(splitString[1] + " sent car");
                        if (so.getLightColour() == "Green")
                        {
                            comboBoxLightColour.SelectedIndex = 2;
                            ResetTimer();
                        }
                    }
                    else
                    {
                        SendMessage("Green");
                    }
                }
                else if(splitString[1] == "top right east")
                {
                    if (comboBoxLightColour.SelectedIndex != 0)
                    {
                        topRightEastTrafficLight.setRef(so);
                        Thread westThread = new Thread(new ThreadStart(so.incrementTopRightEast));
                        westThread.Start();
                        listBoxOutput.Items.Add(splitString[1] + "sent car");
                        if (so.getLightColour() == "Red")
                        {
                            comboBoxLightColour.SelectedIndex = 0;
                            timerTickTockCount = 56;
                        }
                    }
                    else
                    {
                        SendMessage("Red");
                    }
                }
                else if(splitString[1] == "bottom right east")
                {
                    if (comboBoxLightColour.SelectedIndex != 0)
                    {
                        bottomRightEastTrafficLight.setRef(so);
                        Thread westThread = new Thread(new ThreadStart(so.incrementbottomRightEast));
                        westThread.Start();
                        listBoxOutput.Items.Add(splitString[1] + "sent car");
                        if (so.getLightColour() == "Red")
                        {
                            comboBoxLightColour.SelectedIndex = 0;
                            timerTickTockCount = 56;
                        }
                    }
                    else
                    {
                        SendMessage("Red");
                    }
                }
                else if(splitString[1] == "bottom right south")
                {
                    if (comboBoxLightColour.SelectedIndex != 2)
                    {
                        bottomRightSouthTrafficLight.setRef(so);
                        Thread northThread = new Thread(new ThreadStart(so.incrementbottomRightSouth));
                        northThread.Start();
                        listBoxOutput.Items.Add(splitString[1] + " sent car");
                        if (so.getLightColour() == "Green")
                        {
                            comboBoxLightColour.SelectedIndex = 2;
                            ResetTimer();
                        }
                    }
                    else
                    {
                        SendMessage("Green");
                    }
                }
              
                
            }
        }

        //*********************************************************************//
        // Form closing.  If the connection thread was ever created then kill  //
        // it off.                                                             //                               
        //*********************************************************************//
        private void FormServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (threadConnection != null) threadConnection.StopThread();
        }
     
    }   // End of classy class.
}       // End of namespace