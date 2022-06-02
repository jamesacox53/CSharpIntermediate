using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section06Namespace
{
    internal class CallToVideoEncodingWebService : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Call a web service provided by a third-party video " + 
                "encoding service to tell them you have a video ready for encoding.");
        }
    }
}
