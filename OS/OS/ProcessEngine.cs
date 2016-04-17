using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OS
{
    public class ProcessEngine
    {
        private ArrayList processQueue;


        //this method will generate random processes
        public ArrayList randomProcessGenerate() {
            processQueue = new ArrayList();
            Process temp = new Process("10001", 0, 3500); // first process is default
            processQueue.Add(temp);

            Random rnd = new Random();

            for (int i = 2; i <= 10; i++) {
                Process tempProcess = new Process((10000+i).ToString(), rnd.Next(0,10001), rnd.Next(1,8001));
                processQueue.Add(tempProcess);
            }
            return processQueue;
        }


        //this method will generate process as per user's request
        public void userSpecificGenerate() {

        }
    }
}
