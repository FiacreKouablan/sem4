﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_WindowsForms
{
    class Publisher
    {
        //Declare Delegate
        public delegate string PublishMessageDel(string msg, string email);

        //Declare an instance variable which is a Delegate object 
        public PublishMessageDel publishmsg = null;

        //Method used to Invoke Delegate
        public string PublishMessage(string message, string email)
        {
            //Invoke Delegate
           return  publishmsg.Invoke(message, email);
        }
    }
}
