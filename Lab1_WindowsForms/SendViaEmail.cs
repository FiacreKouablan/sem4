using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_WindowsForms
{
    class SendViaEmail
    {
        public static List<string> emails = new List<string>();
        public string EmailAddr { get; set; }

        public SendViaEmail() { }

        //public SendViaEmail(String emailAddr)
        //{
        //    EmailAddr = emailAddr;
        //    // Console.WriteLine(emailAddr);
        //}

        public string sendEmail(string msg)
        {
            StringBuilder sb = new StringBuilder();
            foreach(string email in emails)
                sb.AppendLine($"The message" + "\"" + msg + "\" has already been sent to " + email);
            return sb.ToString();
        }

        public void Subscribe(Publisher pub)
        {
            if (!emails.Contains(EmailAddr))
            {
                emails.Add(EmailAddr);
            }
            foreach (string eeee in emails)
            {
                pub.publishmsg += sendEmail;
            }
        }

        public void UnSubscribe(Publisher pub)
        {
            if (emails.Contains(EmailAddr))
            {
                emails.Remove(EmailAddr);
                
            }
            foreach(string eeee in emails)
            {
                pub.publishmsg -= sendEmail;
            }
            
        }
    }
}
