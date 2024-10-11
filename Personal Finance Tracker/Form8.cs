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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        OleDbConnection conn;
        OleDbCommand cmd;
        private void Form8_Load(object sender, EventArgs e)
        {
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Breyton\Desktop\Personal Finance Tracker.accdb");
            cmd = new OleDbCommand();
            cmd.Connection = conn;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from CREDITCARD";
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter();
            conn.Close();
        }
    }
}
