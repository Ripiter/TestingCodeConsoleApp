using System;
using System.Diagnostics;
using System.Threading;

namespace TestingCodeConsoleApp.Garbage
{
    class ThreadSavety
    {
        static readonly object _object = new object();

        Stopwatch watch = new Stopwatch();

        /// <summary>
        /// Initialize Threads
        /// </summary>
        public void InitializeThreads()
        {
            Thread redThread = new Thread(RedColor);
            Thread greenThread = new Thread(GreenColor);
            Thread yellowThread = new Thread(YellowColor);

            redThread.Start();
            yellowThread.Start();
            greenThread.Start();

            watch.Start();
        }
        

        private void RedColor()
        {
            //Console.ForegroundColor = ConsoleColor.Red;
            PerformeOperation(ConsoleColor.Red);
        }
        private void GreenColor()
        {
            //Console.ForegroundColor = ConsoleColor.Green;
            PerformeOperation(ConsoleColor.Green);
        }
        private void YellowColor()
        {
            //Console.ForegroundColor = ConsoleColor.Yellow;
            PerformeOperation(ConsoleColor.Yellow);
        }

        private void PerformeOperation(ConsoleColor color)
        {
            //Monitor.Enter(_object);
            for (int i = 0; i < 50; i++)
            {
                //monitor allows only thread thread to work on that
                Monitor.Enter(_object);
                Console.ForegroundColor = color;
                Monitor.Exit(_object);
                Console.WriteLine(i);
            }
            //Monitor.Exit(_object);
            
           
            Console.WriteLine(watch.Elapsed);
            //watch.Stop();
        }


    }
}
