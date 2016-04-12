using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS
{
    class Process
    {
        public String name;
        public int arivalTime;
        public int burstTime;
        public int exicutedTime;

        public Process(String name , int arivalTime , int burstTime)
        {
            this.name = name;
            this.arivalTime = arivalTime;
            this.burstTime = burstTime;
        }

       }
}
