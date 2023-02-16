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
    public partial class SSTF : Form
    {
        List<int> queue = new List<int>();
        int size = 0;

        public SSTF()
        {
            InitializeComponent();
        }

        private void SSTF_Load(object sender, EventArgs e)
        {

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
            int[] request = queue.ToArray();
            shortestSeekTimeFirst(request, head);
            
        }
        public class node
        {

          
            public int distance = 0;

          
            public Boolean accessed = false;
        }

        

          
            public int[] queuelast;
            public static void calculateDifference(int[] queue,
                                                int head, node[] diff)
            {
                for (int i = 0; i < diff.Length; i++)
                    diff[i].distance = Math.Abs(queue[i] - head);
            }

           
            public static int findMin(node[] diff)
            {
                int index = -1, minimum = int.MaxValue;

                for (int i = 0; i < diff.Length; i++)
                {
                    if (!diff[i].accessed && minimum > diff[i].distance)
                    {

                        minimum = diff[i].distance;
                        index = i;
                    }
                }
                return index;
            }

            void shortestSeekTimeFirst(int[] request,
                                                            int head)
            {
                if (request.Length == 0)
                    return;

             
                node[] diff = new node[request.Length];

                // initialize array
                for (int i = 0; i < diff.Length; i++)

                    diff[i] = new node();

                
                int seek_count = 0;

               
                int[] seek_sequence = new int[request.Length + 1];

                for (int i = 0; i < request.Length; i++)
                {

                    seek_sequence[i] = head;
                    calculateDifference(request, head, diff);

                    int index = findMin(diff);

                    diff[index].accessed = true;

               
                    seek_count += diff[index].distance;

               
                    head = request[index];
                }

               
                seek_sequence[seek_sequence.Length - 1] = head;
            label2.Text = " ";
                 label2.Text+= seek_count.ToString();

             
            for (int i = 0; i < seek_sequence.Length; i++)
                if (i == 0)
                {
                    label1.Text += (seek_sequence[0]);
                }
                else
                {
                    label1.Text += " --> " + (seek_sequence[i]);
                }

            }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
