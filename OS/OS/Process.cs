using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS
{
    class Process
    {
        public String processID;
        public int arrivalTime;
        public int burstTime;
        public int executedTime;

        public Process(String id , int arrivalTime , int burstTime)
        {
            this.processID = id;
            this.arrivalTime = arrivalTime;
            this.burstTime = burstTime;
        }

        public String getprocessID() {
            return processID;
        }

       }
}
