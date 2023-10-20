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

namespace FrmBasicThreads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Console.WriteLine(lblThread.Text.ToString());
            ThreadStart thread = new ThreadStart(MyThreadClass.Thread1);
            Thread threadA = new Thread(thread);
            Thread threadB = new Thread(thread);
            
            threadA.Start();
            threadA.Name = "Thread A Process";
            threadB.Start();
            threadB.Name = "Thread B Process";
            threadA.Join(); 
            threadB.Join();
            lblThread.Text = "-End of Threading-";
            Console.WriteLine(lblThread.Text.ToString());
        }
    }
}
