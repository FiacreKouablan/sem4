using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_WindowsForms
{
    class SendViaEmail
    {
        public static List<String> emails = new List<string>();
        public String EmailAddr { get; set; }

        public SendViaEmail() { }

        public SendViaEmail(String emailAddr)
        {
            EmailAddr = emailAddr;
            // Console.WriteLine(emailAddr);
        }

        public void setEmail(string email)
        {
            this.EmailAddr = email;

            if (!emails.Contains(EmailAddr))
            {
                emails.Add(EmailAddr);
            }
        }

        public string sendEmail(string msg, string email)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The message" + "\"" + msg + "\" has already been sent to " + email);
            return sb.ToString();
        }

        public void Subscribe(Publisher pub)
        {
            foreach(string eeee in emails)
            {
                pub.publishmsg += sendEmail;
            }
        }

        public void UnSubscribe(Publisher pub)
        {
            emails.Remove(EmailAddr);
            pub.publishmsg -= sendEmail;
        }
    }
}
