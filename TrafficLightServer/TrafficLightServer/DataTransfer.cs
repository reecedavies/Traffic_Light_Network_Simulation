using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightServer
{
    class DataTransfer
    {

        //counters for all traffic lights are set to 1 at the start to fix a bug, but are reset to 0 as soon as the connection is made

        private int topLeftNorthCarCounter = 1;
        private int topLeftSouthCarCounter = 1;
        private int topLeftWestCarCounter = 1;
        private int topLeftEastCarCounter = 1;

        private int topRightNorthCarCounter = 1;
        private int topRightSouthCarCounter = 1;
        private int topRightWestCarCounter = 1;
        private int topRightEastCarCounter = 1;

        private int bottomLeftNorthCarCounter = 1;
        private int bottomLeftSouthCarCounter = 1;
        private int bottomLeftWestCarCounter = 1;
        private int bottomLeftEastCarCounter = 1;

        private int bottomRightNorthCarCounter = 1;
        private int bottomRightSouthCarCounter = 1;
        private int bottomRightWestCarCounter = 1;
        private int bottomRightEastCarCounter = 1;

        //traffic light colour is set to off by default
        private string lightColour = "off";


        public DataTransfer()
        {
        }

        /// <summary>
        /// increment car counter for traffic light and check if greater then 9, if so then change light colour so server knows to change lights.
        /// </summary>
        public void incrementTopLeftNorth()
        {
            topLeftNorthCarCounter++;
            if (topLeftNorthCarCounter > 9)
            {
                lightColour = "Green";
                topLeftNorthCarCounter = 0;
            }
            else
            {
                lightColour = "";
            }

        }
        /// <summary>
        /// increment car counter for traffic light and check if greater then 9, if so then change light colour so server knows to change lights.
        /// </summary>
        public void incrementTopLeftSouth()
        {
            topLeftSouthCarCounter++;
            if (topLeftSouthCarCounter > 9)
            {
                lightColour = "Green";
                topLeftSouthCarCounter = 0;
            }
        }
        /// <summary>
        /// increment car counter for traffic light and check if greater then 9, if so then change light colour so server knows to change lights.
        /// </summary>
        public void incrementTopLeftWest()
        {
            topLeftWestCarCounter++;
            if (topLeftWestCarCounter > 9)
            {
                lightColour = "Red";
                topLeftWestCarCounter = 0;
            }
            else
            {
                lightColour = "";
            }
        }
        /// <summary>
        /// increment car counter for traffic light and check if greater then 9, if so then change light colour so server knows to change lights.
        /// </summary>
        public void incrementTopLeftEast()
        {
            topLeftEastCarCounter++;
            if (topLeftEastCarCounter > 9)
            {
                lightColour = "Red";
                topLeftEastCarCounter = 0;
            }
        }

        /// <summary>
        /// increment car counter for traffic light and check if greater then 9, if so then change light colour so server knows to change lights.
        /// </summary>
        public void incrementTopRightNorth()
        {
            topRightNorthCarCounter++;
            if (topRightNorthCarCounter > 9)
            {
                lightColour = "Green";
                topRightNorthCarCounter = 0;
            }
            else
            {
                lightColour = "";
            }

        }
        /// <summary>
        /// increment car counter for traffic light and check if greater then 9, if so then change light colour so server knows to change lights.
        /// </summary>
        public void incrementTopRightSouth()
        {
            topRightSouthCarCounter++;
            if (topRightSouthCarCounter > 9)
            {
                lightColour = "Green";
                topRightSouthCarCounter = 0;
            }
        }
        /// <summary>
        /// increment car counter for traffic light and check if greater then 9, if so then change light colour so server knows to change lights.
        /// </summary>
        public void incrementTopRightWest()
        {
            topRightWestCarCounter++;
            if (topRightWestCarCounter > 9)
            {
                lightColour = "Red";
                topRightWestCarCounter = 0;
            }
            else
            {
                lightColour = "";
            }
        }
        /// <summary>
        /// increment car counter for traffic light and check if greater then 9, if so then change light colour so server knows to change lights.
        /// </summary>
        public void incrementTopRightEast()
        {
            topRightEastCarCounter++;
            if (topRightEastCarCounter > 9)
            {
                lightColour = "Red";
                topRightEastCarCounter = 0;
            }
        }

        /// <summary>
        /// increment car counter for traffic light and check if greater then 9, if so then change light colour so server knows to change lights.
        /// </summary>
        public void incrementBottomLeftNorth()
        {
            bottomLeftNorthCarCounter++;
            if (bottomLeftNorthCarCounter > 9)
            {
                lightColour = "Green";
                bottomLeftNorthCarCounter = 0;
            }
            else
            {
                lightColour = "";
            }

        }
        /// <summary>
        /// increment car counter for traffic light and check if greater then 9, if so then change light colour so server knows to change lights.
        /// </summary>
        public void incrementBottomLeftSouth()
        {
            bottomLeftSouthCarCounter++;
            if (bottomLeftSouthCarCounter > 9)
            {
                lightColour = "Green";
                bottomLeftSouthCarCounter = 0;
            }
        }
        /// <summary>
        /// increment car counter for traffic light and check if greater then 9, if so then change light colour so server knows to change lights.
        /// </summary>
        public void incrementBottomLeftWest()
        {
            bottomLeftWestCarCounter++;
            if (bottomLeftWestCarCounter > 9)
            {
                lightColour = "Red";
                bottomLeftWestCarCounter = 0;
            }
            else
            {
                lightColour = "";
            }
        }
        /// <summary>
        /// increment car counter for traffic light and check if greater then 9, if so then change light colour so server knows to change lights.
        /// </summary>
        public void incrementBottomLeftEast()
        {
            bottomLeftEastCarCounter++;
            if (bottomLeftEastCarCounter > 9)
            {
                lightColour = "Red";
                bottomLeftEastCarCounter = 0;
            }
        }

        /// <summary>
        /// increment car counter for traffic light and check if greater then 9, if so then change light colour so server knows to change lights.
        /// </summary>
        public void incrementbottomRightNorth()
        {
            bottomRightNorthCarCounter++;
            if (bottomRightNorthCarCounter > 9)
            {
                lightColour = "Green";
                bottomRightNorthCarCounter = 0;
            }
            else
            {
                lightColour = "";
            }

        }
        /// <summary>
        /// increment car counter for traffic light and check if greater then 9, if so then change light colour so server knows to change lights.
        /// </summary>
        public void incrementbottomRightSouth()
        {
            bottomRightSouthCarCounter++;
            if (bottomRightSouthCarCounter > 9)
            {
                lightColour = "Green";
                bottomRightSouthCarCounter = 0;
            }
        }
        /// <summary>
        /// increment car counter for traffic light and check if greater then 9, if so then change light colour so server knows to change lights.
        /// </summary>
        public void incrementbottomRightWest()
        {
            bottomRightWestCarCounter++;
            if (bottomRightWestCarCounter > 9)
            {
                lightColour = "Red";
                bottomRightWestCarCounter = 0;
            }
            else
            {
                lightColour = "";
            }
        }
        /// <summary>
        /// increment car counter for traffic light and check if greater then 9, if so then change light colour so server knows to change lights.
        /// </summary>
        public void incrementbottomRightEast()
        {
            bottomRightEastCarCounter++;
            if (bottomRightEastCarCounter > 9)
            {
                lightColour = "Red";
                bottomRightEastCarCounter = 0;
            }
        }

        /// <summary>
        /// reset car counter to 0 as lights have changed.
        /// </summary>
        public void resetTopLeftNorthCarCounter()
        {
            topLeftNorthCarCounter = 0;
        }
        /// <summary>
        /// reset car counter to 0 as lights have changed.
        /// </summary>
        public void resetTopLeftSouthCarCounter()
        {
            topLeftSouthCarCounter = 0;
        }
        /// <summary>
        /// reset car counter to 0 as lights have changed.
        /// </summary>
        public void resetTopLeftWestCarCounter()
        {
            topLeftWestCarCounter = 0;
        }
        /// <summary>
        /// reset car counter to 0 as lights have changed.
        /// </summary>
        public void resetTopLeftEastCarCounter()
        {
            topLeftEastCarCounter = 0;
        }
        /// <summary>
        /// get the value of the car counter for the server
        /// </summary>
        public int getTopLeftNorthCarCounter()
        {
            return topLeftNorthCarCounter;
        }
        /// <summary>
        /// get the value of the car counter for the server
        /// </summary>
        public int getTopLeftSouthCarCounter()
        {
            return topLeftSouthCarCounter;
        }
        /// <summary>
        /// get the value of the car counter for the server
        /// </summary>
        public int getTopLeftWestCarCounter()
        {
            return topLeftWestCarCounter;
        }
        /// <summary>
        /// get the value of the car counter for the server
        /// </summary>
        public int getTopLeftEastCarCounter()
        {
            return topLeftEastCarCounter;
        }

        /// <summary>
        /// reset car counter to 0 as lights have changed.
        /// </summary>
        public void resettopRightNorthCarCounter()
        {
            topRightNorthCarCounter = 0;
        }
        /// <summary>
        /// reset car counter to 0 as lights have changed.
        /// </summary>
        public void resettopRightSouthCarCounter()
        {
            topRightSouthCarCounter = 0;
        }
        /// <summary>
        /// reset car counter to 0 as lights have changed.
        /// </summary>
        public void resettopRightWestCarCounter()
        {
            topRightWestCarCounter = 0;
        }
        /// <summary>
        /// reset car counter to 0 as lights have changed.
        /// </summary>
        public void resettopRightEastCarCounter()
        {
            topRightEastCarCounter = 0;
        }
        /// <summary>
        /// get the value of the car counter for the server
        /// </summary>
        public int gettopRightNorthCarCounter()
        {
            return topRightNorthCarCounter;
        }
        /// <summary>
        /// get the value of the car counter for the server
        /// </summary>
        public int gettopRightSouthCarCounter()
        {
            return topRightSouthCarCounter;
        }
        /// <summary>
        /// get the value of the car counter for the server
        /// </summary>
        public int gettopRightWestCarCounter()
        {
            return topRightWestCarCounter;
        }
        /// <summary>
        /// get the value of the car counter for the server
        /// </summary>
        public int gettopRightEastCarCounter()
        {
            return topRightEastCarCounter;
        }

        /// <summary>
        /// reset car counter to 0 as lights have changed.
        /// </summary>
        public void resetbottomLeftNorthCarCounter()
        {
            bottomLeftNorthCarCounter = 0;
        }
        /// <summary>
        /// reset car counter to 0 as lights have changed.
        /// </summary>
        public void resetbottomLeftSouthCarCounter()
        {
            bottomLeftSouthCarCounter = 0;
        }
        /// <summary>
        /// reset car counter to 0 as lights have changed.
        /// </summary>
        public void resetbottomLeftWestCarCounter()
        {
            bottomLeftWestCarCounter = 0;
        }
        /// <summary>
        /// reset car counter to 0 as lights have changed.
        /// </summary>
        public void resetbottomLeftEastCarCounter()
        {
            bottomLeftEastCarCounter = 0;
        }
        /// <summary>
        /// get the value of the car counter for the server
        /// </summary>
        public int getbottomLeftNorthCarCounter()
        {
            return bottomLeftNorthCarCounter;
        }
        /// <summary>
        /// get the value of the car counter for the server
        /// </summary>
        public int getbottomLeftSouthCarCounter()
        {
            return bottomLeftSouthCarCounter;
        }
        /// <summary>
        /// get the value of the car counter for the server
        /// </summary>
        public int getbottomLeftWestCarCounter()
        {
            return bottomLeftWestCarCounter;
        }
        /// <summary>
        /// get the value of the car counter for the server
        /// </summary>
        public int getbottomLeftEastCarCounter()
        {
            return bottomLeftEastCarCounter;
        }

        /// <summary>
        /// reset car counter to 0 as lights have changed.
        /// </summary>
        public void resetBottomRightNorthCarCounter()
        {
            bottomRightNorthCarCounter = 0;
        }
        /// <summary>
        /// reset car counter to 0 as lights have changed.
        /// </summary>
        public void resetBottomRightSouthCarCounter()
        {
            bottomRightSouthCarCounter = 0;
        }
        /// <summary>
        /// reset car counter to 0 as lights have changed.
        /// </summary>
        public void resetBottomRightWestCarCounter()
        {
            bottomRightWestCarCounter = 0;
        }
        /// <summary>
        /// reset car counter to 0 as lights have changed.
        /// </summary>
        public void resetBottomRightEastCarCounter()
        {
            bottomRightEastCarCounter = 0;
        }
        /// <summary>
        /// get the value of the car counter for the server
        /// </summary>
        public int getBottomRightNorthCarCounter()
        {
            return bottomRightNorthCarCounter;
        }
        /// <summary>
        /// get the value of the car counter for the server
        /// </summary>
        public int getBottomRightSouthCarCounter()
        {
            return bottomRightSouthCarCounter;
        }
        /// <summary>
        /// get the value of the car counter for the server
        /// </summary>
        public int getBottomRightWestCarCounter()
        {
            return bottomRightWestCarCounter;
        }
        /// <summary>
        /// get the value of the car counter for the server
        /// </summary>
        public int getBottomRightEastCarCounter()
        {
            return bottomRightEastCarCounter;
        }

        /// <summary>
        /// return the lightColour to server
        /// </summary>
        /// <returns></returns>
        public string getLightColour()
        {
            return lightColour;
        }
    }
}
