using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicThreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "     - Thread Running -";
            Thread threadA = new Thread(MyThreadClass.Thread1);
            Thread threadB = new Thread(MyThreadClass.Thread1);

            threadA.Name = "Thread A";
            threadB.Name = "Thread B";

            threadA.Start();
            threadB.Start();

            threadA.Join();
            threadB.Join();

            System.Diagnostics.Debug.WriteLine("- End of Thread");
            label1.Text = "      - End Of Thread -";
        }
    }
}
