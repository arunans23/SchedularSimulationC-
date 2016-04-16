using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //CPUScheduler cpuScheduler = new CPUScheduler();
            
            Application.Run(new initializing());

            /*
            Dispatcher testDis = new Dispatcher();

            Application.Exit();
            Process test = new Process("test", 1, 5);

            ArrayList testArr = new ArrayList();
            testArr.Add(test);

            testDis.setProcessQueue(testArr);
            testDis.dispatchProcess();
            */

        }


    }
}
