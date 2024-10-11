using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Personal_Finance_Tracker
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        OleDbConnection conn;
        OleDbCommand cmd;
        private void Form3_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Breyton\Desktop\Personal Finance Tracker.accdb");
            cmd = new OleDbCommand();
            cmd.Connection = conn;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create way to insert username and password
            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert Personal_Details from(PD_ID = '"+textBox1.Text+"', PD_NAME = '" + textBox2.Text + "', PD_SURNAME = '"+textBox3.Text+"', PD_EMAIL = '"+textBox4.Text+"', PD_ADDRESS = '"+textBox5.Text+"', PD_CELLNO = '"+textBox6.Text+"', PD_PASSWORD = '" + textBox7.Text + "'";
            conn.Close();
            
            //navigate to login after confirm
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
           

        }
    }
}
