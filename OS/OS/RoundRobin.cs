using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            timeQuantum = 1000;
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

        public Boolean terminateProcess(Process process)
            //to remove a process
        {
            ArrayList temp = this.processes;
            processes.Remove(process);
            return true;
        }


        public void setTimeQuantum(int timeQuantum){
            this.timeQuantum = timeQuantum;
        }


        public void setProcessQueue(ArrayList processQueue) {
            this.processes = processQueue;
        }

        public void execute() {
            processes = dispatcher.validateProcessQueue();
            if (processes == null)
            {
                
            }
            else {
                while (processes.Count != 0)
                {
                    for (int i = 0; i < processes.Count; i++)
                    {
                        
                        Process process = (Process)processes[i];
                        int times = (timeQuantum / 200);
                        if (times == 0)
                        {
                            processor.setProcess(process, timeQuantum);
                            processor.execute();
                            dispatcher.updateTime();
                        }
                        else {
                            for (int a = 0; a < times; a++) {
                                
                                processor.setProcess(process, timeQuantum);
                                processor.execute();
                                dispatcher.updateTime();

                                if (process.burstTime - process.executedTime <= 200)
                                {
                                    break;
                                }
                            }
                        }
                        Console.WriteLine(process.burstTime - process.executedTime);
                        if (process.executedTime >= process.burstTime)
                        { 
                            terminateProcess(process);
                            dispatcher.removeProcess(process);
                        }

                        processes = dispatcher.validateProcessQueue();
                    }
                }
            }
        }
    }
}
