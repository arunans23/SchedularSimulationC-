using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS
{
    class ProcessEngine
    {
        private ArrayList processQueue;


        //this method will generate random processes
        public ArrayList randomProcessGenerate() {
            processQueue = new ArrayList();
            Random rnd = new Random();

            for (int i = 1; i <= 10; i++) {
                Process tempProcess = new Process((10000+i).ToString(), rnd.Next(1,11), rnd.Next(1,21));
                processQueue.Add(tempProcess);
            }
            return processQueue;
        }


        //this method will generate process as per user's request
        public void userSpecificGenerate() {

        }
    }
}
