using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] arr = new string[15];
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Hide();
            label2.Hide();
            label4.Hide();
            label5.Hide();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            Random r = new Random();
            
            for (int i = 0; i < 15; i++)
            {
                listBox1.Items.Add(r.Next(1, 100));
               arr[i]= listBox1.Items[i].ToString();

            }
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (Convert.ToDecimal(listBox1.Items[i])%2==1)
	{
        listBox2.Items.Add(listBox1.Items[i]);
	}
            }
                for (int i = 0; i < arr.Length; i++)
                {
                    if (Convert.ToDecimal(listBox1.Items[i]) % 2 == 0)
                    {
                        listBox3.Items.Add(listBox1.Items[i]);
                    }
                }         
            }

        private void button2_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (textBox1.Text==arr[i])
                {
                    label1.Text = "YEs this item is in list box 1";
                    label1.Show();
                }
               
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] arr2 = new int[listBox1.Items.Count];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = int.Parse(listBox1.Items[i].ToString());
            }
            label2.Text = arr2.Sum().ToString();
            label2.Show();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int[] arr3 = new int[listBox2.Items.Count];
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i] = int.Parse(listBox2.Items[i].ToString());
            }
            label5.Text = arr3.Sum().ToString();
            label5.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
              int[] arr4 = new int[listBox3.Items.Count];
            for (int i = 0; i < arr4.Length; i++)
            {
                arr4[i] = int.Parse(listBox3.Items[i].ToString());
            }
            label4.Text = arr4.Sum().ToString();
            label4.Show();
        }
        }
       }
            
            
     


