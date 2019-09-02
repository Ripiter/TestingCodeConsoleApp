using System;
using System.Diagnostics;
using System.Threading;

namespace TestingCodeConsoleApp
{
    class GuidTesting
    {
        //void MainCalling()
        //{
        //    GuidTesting test1 = new GuidTesting();
        //    Thread tr1 = new Thread(test1.Calculating);
        //    Thread tr2 = new Thread(test1.Calculating);
        //    Thread tr3 = new Thread(test1.Calculating);
        //    Thread tr4 = new Thread(test1.Calculating);
        //    tr1.Start();
        //    tr2.Start();
        //    tr3.Start();
        //    tr4.Start();
        //    test1.Calculating();
        //}
        bool running = true;
        public void Calculating()
        {
            var startingNumber = Guid.NewGuid();
            Guid secondNumber;
            DateTime startingTime = DateTime.Now;
            TimeSpan timeWentBy;
            decimal tries = 0;
            decimal codeGotTo = 10000000;
            Console.Title = "Next Checkpoint: " + codeGotTo;
            while (running)
            {
                secondNumber = Guid.NewGuid();

                if (startingNumber == secondNumber)
                {
                    timeWentBy = DateTime.Now - startingTime;
                    Won(timeWentBy, tries.ToString(), secondNumber.ToString());
                }

                if (tries == codeGotTo)
                {
                    Console.Clear();
                    Console.WriteLine(tries);
                    Console.WriteLine(timeWentBy = DateTime.Now - startingTime);
                    Console.WriteLine(secondNumber);
                    codeGotTo = codeGotTo * 2;
                    Console.Title = "Next Checkpoint: " + codeGotTo;
                }
                tries++;
            }
        }
        public void Won(TimeSpan time, string numberOfTries, string winningNumber)
        {
            running = false;
            Console.WriteLine("The end");
            Console.WriteLine(time);
            Console.WriteLine(numberOfTries);
            Console.WriteLine(winningNumber);
            Console.ReadKey(true);
            Console.WriteLine("Are you sure");
            Console.ReadKey(true);
        }

        

        public void Starter()
        {
            Thread tr1 = new Thread(PrinterRandom);
            Thread tr2 = new Thread(PrinterRandomWithGuid);
            tr1.Start();
            tr2.Start();
        }

        void PrinterRandom()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                Random rnd = new Random();
                rnd.Next(1, 1000);
                Console.WriteLine("Thread Random " + stopwatch.Elapsed + " i "+i);
            }
            Console.WriteLine("Done Random");
        }
        void PrinterRandomWithGuid()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 10000; i++)
            {
                Random rnd = new Random(Guid.NewGuid().GetHashCode());
                rnd.Next(1, 10000);
                Console.WriteLine("Thread Guid "+ stopwatch.Elapsed + " i " + i);
            }
            Console.WriteLine("Done Guid");
        }

    }
}
