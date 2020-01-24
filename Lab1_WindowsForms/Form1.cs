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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn_pubnot.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 manageSubscription = new Form2();
            manageSubscription.Show();
            this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
