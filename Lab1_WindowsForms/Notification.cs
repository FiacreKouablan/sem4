using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_WindowsForms
{
    class Notification
    {
        public string email { get; set; }
        public string phoneNumber { get; set; }

        
        public Notification(string email, string phoneNumber)
        {
            this.email = email;
            this.phoneNumber = phoneNumber;
        }
    }
}
