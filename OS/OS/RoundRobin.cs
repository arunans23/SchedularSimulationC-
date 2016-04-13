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
        public Processor processor ;
        public Dispatcher dispatcher;

        public RoundRobin(int quantum)
        {
            this.processor = new Processor();
            this.dispatcher = new Dispatcher(this,quantum);
        }

        public Boolean addProcess(Process process)
            //to add a process.
        {
            foreach (Process p in this.processes)
            {
                if (process.name.ToLower() == p.name.ToLower()) return false;
            }
            this.processes.Add(process);
            return true;
        }

        public Boolean terminateProcess(String name)
            //to remove a process
        {
            ArrayList temp = this.processes;
            foreach (Process p in temp)
            {
                if (p.name == name)
                {
                    processes.Remove(p);
                    return true;
                }
            } return false;
        }

        
       
       

    }
}
