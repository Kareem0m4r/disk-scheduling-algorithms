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
    public partial class SCAN : Form
    {
        List<int> queue = new List<int>();
        int size = 0;
        public int disk_size;
        public string direction;
        public SCAN()
        {
            InitializeComponent();
        }

        private void SCAN_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

         
           disk_size = int.Parse(textBox3.Text);
            if (int.Parse(textBox1.Text)<disk_size)
            {
                queue.Add(int.Parse(textBox1.Text));
                size++;
            }
            else
            {
                MessageBox.Show("request number cannot be greater than disk size");
            }
                
          
            textBox1.Text = " ";
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "LEFT")
            {
                direction = "left";
            }
            else if (comboBox1.Text == "RIGHT")
            {
                direction = "right";
            }
            else
            {
                MessageBox.Show("please choos a direction");
            }
            label1.Text = " ";
            int head = int.Parse(textBox2.Text);
            int[] request = queue.ToArray();
            SCAN1(request, head, direction);
        }

        public class GFG
        {

           
        }

            void SCAN1(int[] arr, int head, String direction)
            {
                int seek_count = 0;
                int distance, cur_track;
                List<int> left = new List<int>(),
                                right = new List<int>();
                List<int> seek_sequence = new List<int>();

              
                if (direction == "left")
                    left.Add(0);
                else if (direction == "right")
                    right.Add(disk_size - 1);

                for (int i = 0; i < size; i++)
                {
                    if (arr[i] < head)
                        left.Add(arr[i]);
                    if (arr[i] > head)
                        right.Add(arr[i]);
                }

                // sorting left and right vectors
                left.Sort();
                right.Sort();

                // run the while loop two times.
                // one by one scanning right
                // and left of the head
                int run = 2;
                while (run-- > 0)
                {
                    if (direction == "left")
                    {
                        for (int i = left.Count - 1; i >= 0; i--)
                        {
                            cur_track = left[i];

                            // appending current track to seek sequence
                            seek_sequence.Add(cur_track);

                            // calculate absolute distance
                            distance = Math.Abs(cur_track - head);

                            // increase the total count
                            seek_count += distance;

                            // accessed track is now the new head
                            head = cur_track;
                        }
                        direction = "right";
                    }
                    else if (direction == "right")
                    {
                        for (int i = 0; i < right.Count; i++)
                        {
                            cur_track = right[i];

                            // appending current track to seek sequence
                            seek_sequence.Add(cur_track);

                            // calculate absolute distance
                            distance = Math.Abs(cur_track - head);

                            // increase the total count
                            seek_count += distance;

                            // accessed track is now new head
                            head = cur_track;
                        }
                        direction = "left";
                    }
                }

            label2.Text = " ";
                label2.Text+=  seek_count ;

            label1.Text = (textBox2.Text);
            for (int i = 0; i < seek_sequence.Count; i++)
                {
                   label1.Text+=" --> " +seek_sequence[i] ;
                }
            }
        



            private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
