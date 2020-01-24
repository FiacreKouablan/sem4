using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_WindowsForms
{
    public partial class Form2 : Form
    {
        Publisher pub = new Publisher();
       public string em;
        public Form2()
        {
            InitializeComponent();
            
        }

        private void numberTxt_Enter(object sender, EventArgs e)
        {
            if (numberTxt.Text == "XXX-XXX-XXXX")
            {
                numberTxt.Text = "";
                numberTxt.ForeColor = Color.Black;
            }
        }

        private void numberTxt_Leave(object sender, EventArgs e)
        {
            if (numberTxt.Text == "")
            {
                numberTxt.Text = "XXX-XXX-XXXX";
                numberTxt.ForeColor = Color.Silver;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 manageNotification = new Form1();
            manageNotification.Show();
            this.Close();
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            em = emailTxt.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,})+)$");
            Match match = regex.Match(emailTxt.Text);
            
            Program.EmailSender.EmailAddr = emailTxt.Text;

            SendViaMobile mobileSender = new SendViaMobile(numberTxt.Text);
            // Notification notification = new Notification(emailTxt.Text, numberTxt.Text);
            
            if (ckbEmail.Checked)
            {
                
                if (emailTxt.Text == "" || !match.Success)
                {
                    invalidEmailTxt.ForeColor = Color.Red;
                    invalidEmailTxt.Text = "Invalid email";
                }
                else
                {
                    
                    Form3 publishNotification = new Form3();
                    publishNotification.Show();
                    this.Visible = false;
                    Program.EmailSender.EmailAddr = emailTxt.Text;
                    Program.EmailSender.Subscribe(pub);
                    
                }
            } else if (ckbSms.Checked)
            {
                Form3 publishNotification = new Form3();
                publishNotification.Show();
                this.Visible = false;
                mobileSender.Subscribe(pub);
            }

           
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void ckbEmail_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbEmail.Checked)
            {
                ckbSms.Enabled = false;
                emailTxt.Enabled = true;
                numberTxt.Enabled = false;
            }
            else
            {
                ckbSms.Enabled = true;
                numberTxt.Enabled = true;
            }
            
        }

        private void ckbSms_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbSms.Checked)
            {
                ckbEmail.Enabled = false;
                numberTxt.Enabled = true;
                emailTxt.Enabled = false;
            }
            else
            {
                ckbEmail.Enabled = true;
                emailTxt.Enabled = true;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.EmailSender.EmailAddr = emailTxt.Text;
            Program.EmailSender.UnSubscribe(pub);
        }
    }
}
