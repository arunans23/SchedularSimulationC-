using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS
{
    public partial class MainWindow : Form
    {
        CPUScheduler cpuScheduler;

        public MainWindow()
        {
            cpuScheduler = new CPUScheduler();
            InitializeComponent();
        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList arry = new ArrayList();
            arry.Add(new Process("isham", 10, 12));
            arry.Add(new Process("bob", 10, 12));
            arry.Add(new Process("isbo", 10, 12));
            arry.Add(new Process("isgi", 10, 12));
            ArrayList test = arry;
            if (arry[0] == test[0])
            {
                arry.Remove(test[0]);
                MessageBox.Show("done");
            }
            MessageBox.Show("not Done");
        }
        */

        private void button1_Click_1(object sender, EventArgs e)
        {
            var processWindow = new initializing();
            processWindow.Show();
            processWindow.setCPUScheduler(cpuScheduler);
        }

        private void main_start_Click(object sender, EventArgs e)
        {
            cpuScheduler.getDispatcher().dispatchProcess();
        }
    }
}
