using System;
using System.Threading;
using System.Collections.Generic;

namespace TestingCodeConsoleApp
{
    class ExitingLoop
    {
        /// <summary>
        /// Code inside of the main in program
        /// </summary>
        public void Main()
        {
            ExitingLoop a = new ExitingLoop();
            Thread tr1 = new Thread(a.Threading);
            tr1.Start();
            a.WhileLoop();
            Console.ReadKey();
        }

        //static readonly object _object = new object();
        private static bool running = true;
        public void WhileLoop()
        {
            //Monitor.Enter(_object);
            while(running)
            {
                Console.WriteLine("In while loop");
                Console.WriteLine("Running = " + running);
                Thread.Sleep(500);
            }
            Console.WriteLine("outside of while loop");
            //Monitor.Exit(_object);
        }
        public void Threading()
        {
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                running = false;
                Console.WriteLine("stopping");
            }
        }
    }
}
