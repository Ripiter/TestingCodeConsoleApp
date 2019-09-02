using System;
using System.Collections.Generic;
using System.Threading;

namespace TestingCodeConsoleApp.UsefullStuff
{
    public class RandomTesting
    {
        public void RandomWithTime()
        {
            // Random is using system clock, and the random is "refreshed"
            // every 15 milisecond
            Random rnd = new Random();
            Random rand = new Random();
           
            Random randomTimeMili = new Random(DateTime.Now.Millisecond);
            Random randomTimeMili2 = new Random(DateTime.Now.Millisecond);
            Random randomTimeSec = new Random(DateTime.Now.Second);
            Random randomTimeMin = new Random(DateTime.Now.Minute);

            Console.WriteLine(rnd.Next(0,1000));
            Console.WriteLine(rand.Next(0,1000));
            Console.WriteLine();

            Console.WriteLine(randomTimeMili.Next(0,1000));
            Console.WriteLine(randomTimeMili2.Next(0,1000));
            Console.WriteLine(randomTimeSec.Next(0,1000));
            Console.WriteLine(randomTimeMin.Next(0,1000));
        }
    }
}
