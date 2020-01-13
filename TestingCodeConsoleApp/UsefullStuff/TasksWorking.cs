using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestingCodeConsoleApp.UsefullStuff
{
    class TasksWorking
    {

        public TasksWorking()
        {
            Task<double>[] taskArray = { Task<double>.Factory.StartNew(() => DoComputation(1.0)),
                                         Task<double>.Factory.StartNew(() => DoComputation(100.0)),
                                         Task<double>.Factory.StartNew(() => DoComputation(1000.0))};
            
            double[] results = new double[taskArray.Length];
            double sum = 0;

            for (int i = 0; i < taskArray.Length; i++)
            {
                results[i] = taskArray[i].Result;
                // if i == taskArray.Length -1 { add "= " else add "+ " }
                Console.Write("{0:N1} {1}", results[i], i == taskArray.Length - 1 ? "= " : "+ ");
                sum += results[i];
            }
            Console.WriteLine("{0:N1}", sum);
        }
        private double DoComputation(double start)
        {
           //Console.WriteLine("Do conputation with value: " + start);
            double sum = 0;

            for (double value = start; value <= start + 10; value += .1)
            {
                Console.WriteLine("start " + start);
                Console.WriteLine("sum " + sum);
                Console.WriteLine("value " + value);
                //Console.WriteLine(Thread.CurrentThread.Name);
                sum += value;
                
            }

            return sum;
        }
    }
}