using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS
{
    class Dispatcher
    {
        RoundRobin rr;

        ArrayList processQueue;


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

        //currently only Roundrobin is set as default
        public void dispatchProcess() {
            rr.setProcessQueue(processQueue);
            rr.execute();
        }
    }
}
