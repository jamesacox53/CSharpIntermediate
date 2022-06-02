using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section06Namespace
{
    internal class Exercises1
    {
        static void Main(string[] args)
        {
            Exercise1();
        }

        public static void Exercise1()
        {
            IActivity uploadVideo = new UploadVideo("testfile.mp4");
            IActivity callToVideoEncodingWebService = new CallToVideoEncodingWebService();
            IActivity sendEmail = new SendEmail();
            IActivity videoProcessed = new VideoProcessed();

            Workflow workflow = new Workflow();
            workflow.AddActivity(uploadVideo);
            workflow.AddActivity(callToVideoEncodingWebService);
            workflow.AddActivity(sendEmail);
            workflow.AddActivity(videoProcessed);

            WorkflowEngine engine = new WorkflowEngine();
            engine.Run(workflow);

            Console.ReadKey();
        }
    }
}
