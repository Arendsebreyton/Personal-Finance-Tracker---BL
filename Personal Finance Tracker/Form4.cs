using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Personal_Finance_Tracker
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
              
        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }
   
        private void button1_Click(object sender, EventArgs e)
        {
            
            Form5 F5 = new Form5();
            F5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 F6 = new Form6();
            F6.Show();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            
            Form11 F11 = new Form11();
            F11.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Form7 F7 = new Form7();
            F7.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Form8 F8 = new Form8();
            F8.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            Form9 F9 = new Form9();
            F9.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            Form10 F10 = new Form10();
            F10.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
            Form12 F12 = new Form12();
            F12.Show();
        }

        
       
    }
}
