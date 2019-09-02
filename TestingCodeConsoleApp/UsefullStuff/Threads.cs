using System;
using System.Threading;

namespace TestingCodeConsoleApp.UsefullStuff
{
    class Threads
    {
        private object valuee = null;

        public object Value
        {
            get { return valuee; }
            set { valuee = value; }
        }

        public void Yeet()
        {
            // Runs racing method and sets the return value in the Value object 
            Thread thread = new Thread(() => { Value = new Boy().Racing(); });
            Thread thread2 = new Thread(new Boy().Race);

            thread.Name = "first thread";
            thread2.Name = "second thread";

            thread.Start();
            thread2.Start();
            
            // makes it all work
            thread.Join();
        }
    }
    class Boy
    {
        public void Race()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"second loop that should start {Thread.CurrentThread.Name}");
            }
        }
        public string Racing()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine($"first loop that should start {Thread.CurrentThread.Name}");
            }
                return "Racing without loop";
        }
    }
}
