using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS
{
    public class Process
    {
        public String processID;
        public int arrivalTime;
        public int burstTime;
        public int executedTime;
        public int waitingTime;

        public Process(String id , int arrivalTime , int burstTime)
        {
            this.processID = id;
            this.arrivalTime = arrivalTime;
            this.burstTime = burstTime;
            executedTime = 0;
            waitingTime = 0;
        }

        public String getprocessID() {
            return processID;
        }

       }
}
