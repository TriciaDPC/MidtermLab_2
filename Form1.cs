using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class FrmBasicThread : Form
    {
        public Thread ThreadA, ThreadB;


        public FrmBasicThread()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before Starting thread-");
            ThreadStart threadssss = new ThreadStart(MyThreadClass.Thread1);

            ThreadA = new Thread(threadssss);
            ThreadA.Name = "Thread A Process";

            ThreadB = new Thread(threadssss);
            ThreadB.Name = "Thread B Process";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            Console.WriteLine("-End of thread-");
            label1.Text = ("-End of thread-");
        }

       
        private void FrmBasicThread_Load(object sender, EventArgs e)
        {

        }
    }
}
