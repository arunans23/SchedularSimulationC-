using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace OS
{
    class Processor
    {
        public Process currentProcess;
        private int allowedTime;

        public void setProcess(Process process, int time)
        {
            this.currentProcess = process;
            this.allowedTime = time;
        }

        public Process returnProcess()
        {
            Process temp = this.currentProcess;
            this.currentProcess = null;
            return temp;
        }

        public Boolean execute()
        {
            if (this.currentProcess != null)
            {
                //this.currentProcess.executedTime++;
                //return true;

                /*
                for (int i = 1; i <= allowedTime; i++) {
                    if (currentProcess.burstTime != currentProcess.executedTime){
                        Console.WriteLine(currentProcess.getprocessID() + " running...");
                        currentProcess.executedTime++;
                        currentProcess.waitingTime--;   //to balance off the increased waitingTime
                    }
                    else return false;
                }
                */

                Thread.Sleep(200);
                currentProcess.executedTime += 200;
                Console.WriteLine(currentProcess.getprocessID() + " running...");

            } 
            return false;
            
        }
    }
}
