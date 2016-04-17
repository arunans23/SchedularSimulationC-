using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace OS
{
    public class Dispatcher
    {
        RoundRobin rr;

        ArrayList processQueue;
        ArrayList validatedProcessQueue;   //used to create a process Queue which based on arrival time

        int currentTime;

        public Dispatcher()
        {
            this.rr = new RoundRobin(this);

        }

        //the logics for the round robin algorithm will be bellow

        public void setProcessQueue(ArrayList processes) {
            this.processQueue = processes;
        }

        public ArrayList getProcessQueue() {
            return processQueue;
        }

        public void removeProcess(Process process) {
            if (processQueue.Contains(process)) {
                processQueue.Remove(process);
            }
        }

        //currently only Roundrobin is set as default
        public void dispatchProcess() {
            int currentTime = 0;
            if (processQueue == null)
            {
                MessageBox.Show("Process Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                validatedProcessQueue = new ArrayList();
                validateProcessQueue();
                rr.setProcessQueue(validatedProcessQueue);
                rr.execute();
            }
                    Console.WriteLine("Process finished");
            
        }

        public ArrayList validateProcessQueue() {
            for (int i = 0; i < processQueue.Count; i++) {
                Process temp = (Process)processQueue[i];
                if (temp.arrivalTime <= currentTime) {
                    if (validatedProcessQueue.Contains(temp))
                    {
                    }
                    else {
                        validatedProcessQueue.Add(temp);
                    }
                    
                    //Console.WriteLine(temp.processID + "/t" + temp.arrivalTime + "/t" + temp.waitingTime);
                }
            }
            return validatedProcessQueue;
        }


        public void updateTime() {
            currentTime += 200;
            for (int m = 0; m < validatedProcessQueue.Count; m++) {
                Process temp = (Process)validatedProcessQueue[0];
                //temp.waitingTime++;
            }
        }
    }
}
