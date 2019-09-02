using System;
using System.Threading;

namespace TestingCodeConsoleApp
{
    class MultiThreading
    {
        //object for monitor or lock
        object _object = new object();

        //object for printing value
        private object valuee = null;

        public object Value
        {
            get { return valuee; }
            set { valuee = value; }
        }

        private string valueeTest = null;

        public string ValueTest
        {
            get { return valueeTest; }
            set { valueeTest = value; }
        }

        public Thread Thread2
        {
            get
            {
                return thread2;
            }
            set
            {
                thread2 = value;
            }
        }

        Thread thread;
        Thread thread2;

        public MultiThreading()
        {
            // Runs racing method and sets the return value in the Value object 
            thread = new Thread(() => { Value = Racing(); });
            thread2 = new Thread(Race);

            thread.Name = "first thread";
            thread2.Name = "second thread";
        }
        public void StartThreading()
        {
            thread.Start();
            thread2.Start();

            // makes it all work
            thread.Join();
        }


        public void Race()
        {
            for (int i = 0; i < 3; i++)
            {
                ValueTest = $"we are in loop {i}";
                Console.WriteLine($"second loop that should start {Thread.CurrentThread.Name}");
            }
        }
        public string Racing()
        {
            //Console.WriteLine("laps " + Laps);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"first loop that should start {Thread.CurrentThread.Name}");
            }
            return "Racing without loop";
        }

        /// <summary>
        /// In Program
        /// </summary>
        //static MultiThreading s;
        //static void Main(string[] args)
        //{
        //    object _object = new object();
        //    Thread thr = new Thread(Printing);
        //    s = new MultiThreading();
        //    thr.Start();
        //    s.StartThreading();


        //    Console.WriteLine(s.Value);

        //    Console.ReadKey();
        //}
        //static void Printing()
        //{
        //    while (s.Thread2.IsAlive)
        //    {
        //        if (s.ValueTest != null)
        //            Console.WriteLine(s.ValueTest);
        //    }
        //}
    }
}
