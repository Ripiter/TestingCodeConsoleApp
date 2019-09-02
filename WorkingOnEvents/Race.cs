using System;
using System.Diagnostics;
using System.Threading;

namespace WorkingOnEvents
{
    class Race
    {
        Thread tr1;
        Thread tr2;
        Stopwatch stopwatch;
        readonly object _object = new object();


        /// <summary>
        /// Initialize threads
        /// </summary>
        public Race()
        {
            tr1 = new Thread(Racing);
            tr2 = new Thread(Racing);

            tr1.Name = "Thread 1";
            tr2.Name = "Thread 2";
            stopwatch = new Stopwatch();
        }

        /// <summary>
        /// Starts threads
        /// </summary>
        public void Start()
        {
            stopwatch.Start();
            tr1.Start();
            tr2.Start();

        }

        /// <summary>
        /// Run procceds here
        /// </summary>
        public void Racing()
        {
            HoldingValues values = new HoldingValues();

            values.Name = Thread.CurrentThread.Name;
            for (int i = 0; i < 5; i++)
            {
                Accident(Thread.CurrentThread);
                values.Laps = i;
                values.Time = stopwatch.Elapsed;
                WhenLapEnd(values);
                Thread.Sleep(5000);
            }
        }
        private void Accident(Thread tr)
        {
            if (new Random(Guid.NewGuid().GetHashCode()).Next(10) < 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(Thread.CurrentThread.Name + " had accident");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        private void WhenLapEnd(HoldingValues e)
        {
            if (ValueHolder != null)
                ValueHolder(this, e);
        }
        public event EventHandler<HoldingValues> ValueHolder;
    }

    public class HoldingValues
    {
        public int Laps { get; set; }
        public string Name { get; set; }
        public TimeSpan Time { get; set; }
    }

}

//Void Main()
//{
//    Race race = new Race();
//    race.ValueHolder += c_ThresholdReached;
//    race.Start();
//    Console.ReadKey(true);
//}
//public static void c_ThresholdReached(object sender, HoldingValues e)
//{
//    Console.WriteLine($"{e.Name} finished lap {e.Laps} with time {e.Time}");
//}
