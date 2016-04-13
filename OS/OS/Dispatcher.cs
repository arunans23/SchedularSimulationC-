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
        int timeQuantum;
        public Dispatcher(RoundRobin rr , int quantum)
        {
            this.rr = rr;
            this.timeQuantum = quantum;
        }

        //the logics for the round robin algorithm will be bellow


    }
}
