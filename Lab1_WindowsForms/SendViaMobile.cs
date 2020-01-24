using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_WindowsForms
{
    class SendViaMobile
    {
        List<String> phoneNumbers = new List<string>();
        private String CellPhone { get; set; }

        public SendViaMobile() { }

        public SendViaMobile(String phone)
        {
            CellPhone = phone;
        }

        private string sendMessage(string msg, string phone)
        {
            return $"The message " + "\"" + msg + "\" has already been texted to " + phone;
        }

        public void Subscribe(Publisher pub)
        {
            phoneNumbers.Add(CellPhone);
            pub.publishmsg += sendMessage;
        }

        public void UnSubscribe(Publisher pub)
        {
            phoneNumbers.Remove(CellPhone);
            pub.publishmsg -= sendMessage;
        }
    }
}
