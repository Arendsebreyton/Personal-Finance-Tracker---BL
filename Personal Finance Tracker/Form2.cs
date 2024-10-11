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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public class PrivacyPolicy
        {
            //public string Text { get; set; }
            public string Accepted { get; set; }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
           
            Button acceptButton = new Button();
            acceptButton.Text = "Accept";
            acceptButton.DialogResult = DialogResult.OK;
            /*privacyPolicyForm.AcceptButton = AcceptButton;
            privacyPolicyForm.Controls.Add(acceptButton);*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //initialize form text and size
            this.Text = "Privacy Policy qdjvsjvdjsdsgdsjvdsjs";
            this.Size = new System.Drawing.Size(664, 350);

            //create a richTextBox to display the privacy policy text
            //RichTextBox richTextBox = new RichTextBox();
            //richTextBox.Dock = DockStyle.Fill;
            //this.Controls.Add(richTextBox);

            //add the privacy policy text

            Button acceptButton = new Button();
            acceptButton.Text = "Accept";
            acceptButton.DialogResult = DialogResult.OK;
            /*privacyPolicyForm.AcceptButton = AcceptButton;
            privacyPolicyForm.Controls.Add(acceptButton);*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Information We Collect:\nAccount information(username,password,email address),Financial data(account balances, transactio history),Device informtion(IP address, device type).\nUse of Information:\nTo provide and improve our services, to communicate with you about your account and services, to comply with legal and regulatory requirements\nData Security\nWe use encryption to protect your data, we use secure servers to store your data, we limit access to your data to authorized personnel\nData Sharing\nWe do not share your data with third parties, we may share aggregated and anonymized data for research purposes\nYour Rights\nYou have the right to access and coorrect your data, you have the right to request data deletion, you have the right to opt-out- of data collection\nChanges to This Policy\nWe may update this policy from time to time, we will notify you of changes by email or through our app";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Thank you for reading the privacy policy");
                this.Hide();
                Form3 F3 = new Form3();
                F3.Show();
            }
            else
            {
                MessageBox.Show("PLEASE READ AND UNDERSTAND THE PRIVACY POLICY");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //show message box confirming the decline
            DialogResult result = MessageBox.Show("Are you sure you want to decline the privacy policy?");
            if(result ==DialogResult.Yes)
            {
                // perform actions to decline the privacy policy, such as:
                //-close the application
                //- show message indicating that the user must accept the privacy policy to use the application
                //- disable certain features or functionality
            }
        }
    }
}
