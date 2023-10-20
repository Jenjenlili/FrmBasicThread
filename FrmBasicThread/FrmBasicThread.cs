using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FrmBasicThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Thread ThreadA;
        private Thread ThreadB;
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart start = new ThreadStart(MyThreadClass.Thread1);

            Console.WriteLine(label1.Text.ToString());

            ThreadA = new Thread(start);
            ThreadA.Name = "Thread A Process";
            ThreadA.Start();

            ThreadB = new Thread(start);
            ThreadB.Name = "Thread B Process";
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            label1.Text = "-End of Thread-";
            Console.WriteLine(label1.Text.ToString());
        }
    } 
}
