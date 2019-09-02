using System;
using DllMakesDotNetFramework;

namespace TestingCodeConsoleApp
{
    class Calculating
    {
        /// <summary>
        /// Code that should be in menu
        /// </summary>
        public void Main()
        {
            Calculating calculating = new Calculating();

            Console.WriteLine(calculating.Minus(10, 5));
            calculating.Print(10, 5);
            calculating.AAA();
            calculating.BBB();
            Console.ReadKey(true);
        }

        Calculator calculator = new Calculator();
        SmallLoops a = new SmallLoops();
        BigLoops b = new BigLoops();
        PrivateClass c = new PrivateClass();
        public void AAA()
        {
            a.SmallForLoops();
        }
        public void BBB()
        {
            BigLoops.BBBB();
        }

        public double Add(double a, double b)
        {
            return calculator.Add(a, b);
        }
        public double Minus(double a, double b)
        {
            return calculator.Minus(a, b);
        }
        public double Times(double a, double b)
        {
            return calculator.Times(a, b);
        }
        public void Print(double a, double b)
        {
            calculator.TimeWithConsole(a, b);
        }
        

    }
}
