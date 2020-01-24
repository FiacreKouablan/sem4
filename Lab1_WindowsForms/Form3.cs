using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_WindowsForms
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form2 manageSubscription = new Form2();
            manageSubscription.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form2 manageSubscription = new Form2();
            string message="";
            Publisher pub = new Publisher();
            //Program.EmailSender = new SendViaEmail(manageSubscription.em);
            //SendViaMobile mobileSender = new SendViaMobile();
            
            //foreach(SendViaEmail ema in SendViaEmail.emails)
            {
                //ema = emailSender.EmailAddr;
                message += Program.EmailSender.sendEmail(notContentTxt.Text);
            }
           MessageBox.Show(message);

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void notContentTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
