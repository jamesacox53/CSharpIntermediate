using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section02Namespace
{
    internal class Exercises1
    {
        static void Main(string[] args)
        {
            // Exercise1();
            Exercise2();
        }

        public static void Exercise1()
        {
            StopWatch stopWatch = new StopWatch();

            UseStopWatch(stopWatch, 5);

            UseStopWatch(stopWatch, 2);

            UseStopWatch(stopWatch, 7);

            UseStopWatch(stopWatch, 1);

            Console.ReadKey();
        }

        private static void UseStopWatch(StopWatch stopWatch, int numSeconds)
        {
            int milliSeconds = numSeconds * 1000;

            stopWatch.Start();

            System.Threading.Thread.Sleep(milliSeconds);

            TimeSpan time = stopWatch.Stop();

            Console.WriteLine("Time difference in seconds: " + time.TotalSeconds);
        }

        public static void Exercise2()
        {
            string title = "how to turn on computer?";

            string description = "Marked as duplicate.";
            
            Post post = new Post(title, description);

            post.DownVote();
            post.DownVote();
            post.DownVote();
            post.UpVote();
            post.DownVote();
            post.DownVote();

            Console.WriteLine("Title: " + post.Title);
            Console.WriteLine("Description: " + post.Description);

            Console.WriteLine(post.VoteValue);
            Console.ReadKey();
        }
    }
}
