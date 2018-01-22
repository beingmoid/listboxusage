using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace OOP_LAB_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            operations op = new operations(lstRandom, lstOdd, lstEven);



            op.GenerateNumbers(lstRandom, lstEven, lstOdd);
            StreamWriter sw = new StreamWriter("txtfile.txt",true);
            sw.WriteLine(op.sumeven.ToString());
            sw.WriteLine(op.sumodd.ToString());
            sw.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
