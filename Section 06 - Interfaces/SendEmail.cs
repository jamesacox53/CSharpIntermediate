using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section06Namespace
{
    internal class SendEmail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Send an email to the owner of the video notifying them " + 
                "that the video started processing.");
        }
    }
}
