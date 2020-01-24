using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_WindowsForms
{
    static class Program
    {
        public static SendViaEmail EmailSender { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            EmailSender = new SendViaEmail();
            Application.Run(new Form1());
        }
    }
}
