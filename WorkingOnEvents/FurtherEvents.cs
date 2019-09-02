using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingOnEvents
{
    class FurtherEvents
    {
        private PrintHelper printHelper;

        public FurtherEvents(int val)
        {
            printHelper = new PrintHelper();

            Value = val;

            //subscribe to beforePrintEvent event
            printHelper.beforePrintEvent += printHelper_beforePrintEvent;
        }
        //beforePrintevent handler
        void printHelper_beforePrintEvent()
        {
            Console.WriteLine("BeforPrintEventHandler: PrintHelper is going to print a value");
        }

        private int value;

        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public string PrintMoney()
        {
            return printHelper.PrintMoney(value);
        }

        public string PrintNumber()
        {
            return printHelper.PrintNumber(value);
        }
    }

    public class PrintHelper
    {
        // declare delegate 
        public delegate void BeforePrint();

        //declare event of type delegate
        public event BeforePrint beforePrintEvent;

        public PrintHelper()
        {

        }

        public string PrintNumber(int num)
        {
            //value of delegate will be null if no event is subscribed
            //therefor we are checking if its null
            if (beforePrintEvent != null)
                beforePrintEvent();

            return  string.Format("Number: {0,-12:N0}", num);
        }
        public string PrintMoney(int money)
        {
            if (beforePrintEvent != null)
                beforePrintEvent();

            return string.Format("Money: {0:C}", money);
        }
    }
}
