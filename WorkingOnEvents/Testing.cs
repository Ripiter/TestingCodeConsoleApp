using System;

namespace WorkingOnEvents
{
    class Testing
    {
        public event EventHandler<HoldingVariable> ThresholdReached;

        public void Run()
        {
                HoldingVariable args = new HoldingVariable();
                //we are setting value to variables in the class
                args.Threashold = 420;
                args.Time = DateTime.Now;

            for (int i = 0; i < 2; i++)
            {
                WhenEndReached(args);
            }
        }
        private void WhenEndReached(HoldingVariable e)
        {
            EventHandler<HoldingVariable> handler = ThresholdReached;
            //Who is is sending and what value we are sending
            if (handler != null)
                ThresholdReached(this, e);
        }

    }

    /// <summary>
    /// This class owns from EventArgs
    /// </summary>
    public class HoldingVariable
    {
        public int Threashold { get; set; }
        public DateTime Time { get; set; }
    }
}

//static void Main(string[] args)
//{
//    Testing c = new Testing();

//    c.ThresholdReached += c_ThresholdReached;
//    c.Run();

//    Console.ReadKey(true);
//}
//public static void c_ThresholdReached(object sender, HoldingVariable e)
//{
//    Console.WriteLine("The threshold of {0} was reached at {1}.", e.Threashold, e.Time);
//}
