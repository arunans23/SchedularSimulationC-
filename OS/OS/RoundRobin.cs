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
        public ArrayList processes=new ArrayList() ;
        public int timeQuantum;

        
        public void setQuantum(int quantum){
            this.timeQuantum = quantum;
        }
        
        public void addProcess(Process process)
        {
            this.processes.Add(process);
        }

        public void terminateProcess(Process process)
        {
            foreach (Process prs in processes)
            {
                if (prs == process)
                {

                }
            }
        }

    }
}
