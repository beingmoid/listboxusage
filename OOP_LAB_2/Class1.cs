using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OOP_LAB_2
{
    class operations
    {
        public int sumeven=0;
        public int sumodd=0;
       
        public operations(ListBox lstRandom, ListBox lstOdd, ListBox lstEven)
        {
            lstRandom.Items.Clear();
            lstOdd.Items.Clear();
            lstEven.Items.Clear();
            lstEven.BackColor = Color.White;
            lstOdd.BackColor = Color.White;    
        }
        public operations()
        {

        }

        public void Reset(ListBox lstRandom, ListBox lstOdd, ListBox lstEven)
        {
            lstRandom.Items.Clear();
            lstOdd.Items.Clear();
            lstEven.Items.Clear();
            lstEven.BackColor = Color.White;
            lstOdd.BackColor = Color.White;
        }
        public void GenerateNumbers(ListBox lstRandom, ListBox lstEven,ListBox lstOdd)
        { 
           Random r = new Random();
            for (int i = 0; i < 10; i++)
			{
             lstRandom.Items.Add(r.Next(1,100));
			}
            
            for (int i = 0; i < lstRandom.Items.Count; i++)
			{
			 if (int.Parse(lstRandom.Items[i].ToString())%2==0)
	{
        lstEven.Items.Add(lstRandom.Items[i]);
        
       

	}
             else if(int.Parse(lstRandom.Items[i].ToString())%2==1)
	
             {
                 lstOdd.Items.Add(lstRandom.Items[i]);
                 
               
             }
           
                
              
            
			}
            int[] arr = new int[lstEven.Items.Count];

            int[] arr2 = new int[lstOdd.Items.Count];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(lstEven.Items[i].ToString());
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = int.Parse(lstOdd.Items[i].ToString());
            }
            sumeven = arr.Sum();
            sumodd = arr2.Sum();


            if (sumeven > 5)
            {
                lstEven.BackColor = Color.Blue;

            }
            if (sumodd > 5)
            {
                lstOdd.BackColor = Color.Green;
            }
        }

    }
}
