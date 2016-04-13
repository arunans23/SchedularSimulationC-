using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS
{
    class Processor
    {
        public Process currentProcess;

        public void setProcess(Process process)
        {
            this.currentProcess = process;
        }

        public Process returnProcess()
        {
            Process temp = this.currentProcess;
            this.currentProcess = null;
            return temp;
        }

        public Boolean exicute()
        {
            if (this.currentProcess != null)
            {
                this.currentProcess.exicutedTime++;
                return true;
            } 
            return false;
            
        }
    }
}
