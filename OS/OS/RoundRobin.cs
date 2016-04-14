using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS
{
    class RoundRobin
    {
        public ArrayList processes ;
        public Processor processor ;
        public Dispatcher dispatcher;
        int timeQuantum;

        public RoundRobin(Dispatcher dispatcher)
        {
            processor = new Processor();
            this.dispatcher = dispatcher;
            timeQuantum = 10;
        }

        public Boolean addProcess(Process process)
            //to add a process.
        {
            foreach (Process p in this.processes)
            {
                if (process.processID.ToLower() == p.processID.ToLower()) return false;
            }
            this.processes.Add(process);
            return true;
        }

        public Boolean terminateProcess(String PID)
            //to remove a process
        {
            ArrayList temp = this.processes;
            foreach (Process p in temp)
            {
                if (p.processID == PID)
                {
                    processes.Remove(p);
                    return true;
                }
            } return false;
        }


        public void setTimeQuantum(int timeQuantum){
            this.timeQuantum = timeQuantum;
        }


        public void setProcessQueue(ArrayList processQueue) {
            this.processes = processQueue;
        }

        public void execute() {
            foreach (Process process in processes) {
                processor.setProcess(process, timeQuantum);
                processor.execute();
            }
        }
    }
}
