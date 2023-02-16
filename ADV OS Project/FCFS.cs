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
    public partial class FCFS : Form
    {
        List<int> queue = new List<int>();
        int size = 0;

        public FCFS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            queue.Add(int.Parse(textBox1.Text));
            size++;
            textBox1.Text = " ";
            textBox2.Enabled = false;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = " ";
            int head = int.Parse(textBox2.Text);
            //for (int i = 0; i < queue.Count ; i++)
            //{
            //    label1.Text+=(" --> " + queue[i].ToString()) ;
            //}
            FCFS1(queue, head);
        }


         void FCFS1(List<int> queue , int head)
        {
            int seek_count = 0;
            int distance, cur_track;

            for (int i = 0; i < size; i++)
            {
                cur_track = queue[i];

             
                distance = Math.Abs(cur_track - head);

               
                seek_count += distance;

             
                head = cur_track;
            }

            label2.Text=("total distance= " +
                                      seek_count);

          
                label1.Text = (textBox2.Text);
          
         
            for (int i = 0; i < size; i++)
            {
                label1.Text+= " --> " + int.Parse(queue[i].ToString());
            }
        }

        private void FCFS_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
            
        }
    }
}
