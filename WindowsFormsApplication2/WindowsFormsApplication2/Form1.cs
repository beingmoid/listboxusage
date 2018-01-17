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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            string[] arr = new string[15];
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
            
            
        }
    }

