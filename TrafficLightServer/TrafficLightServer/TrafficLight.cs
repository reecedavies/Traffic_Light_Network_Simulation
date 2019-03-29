using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLightServer
{
    class TrafficLight
    {
        //obj is the object that allows access to the car counters in threads
        DataTransfer obj;

        public TrafficLight()
        {
        }
        /// <summary>
        /// set the connection
        /// </summary>
        /// <param name="sho"></param>
        public void setRef(DataTransfer sho)
        {
            obj = sho;
        }
        /// <summary>
        /// another method of incrementing the top left north car counter
        /// </summary>
        public void runTopLeftNorth()
        {
            obj.incrementTopLeftNorth();
        }
        /// <summary>
        /// another method of incrementing the top left south car counter
        /// </summary>
        public void runTopLeftSouth()
        {
            obj.incrementTopLeftSouth();
        }

        /// <summary>
        /// another method of incrementing the top left west car counter
        /// </summary>
        public void runTopLeftWest()
        {
            obj.incrementTopLeftWest();
        }
        /// <summary>
        /// another method of incrementing the top left east car counter
        /// </summary>
        public void runTopLeftEast()
        {
            obj.incrementTopLeftEast();
        }

    }
}
