using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADV_OS_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FCFS FCFS = new FCFS();
            FCFS.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SSTF SSTF = new SSTF();
            SSTF.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SCAN SCAN= new SCAN();
            SCAN.Show();
        }
    }
}
