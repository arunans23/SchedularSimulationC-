using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS
{
    public class CPUScheduler
    {
        private Dispatcher dispatcher;
        private ProcessEngine processEngine;

        public CPUScheduler() {
            dispatcher = new Dispatcher();
            processEngine = new ProcessEngine();
        }

        public ProcessEngine getProcessEngine() {
            return processEngine;
        }

        public Dispatcher getDispatcher() {
            return dispatcher;
        }
    }
}
