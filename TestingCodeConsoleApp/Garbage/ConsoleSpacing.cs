using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCodeConsoleApp
{
    public class ConsoleSpacing
    {
        string shortString = "Aplication";
        //string longerString = "Aplication";
        string longestString = "Game";

        public void ConsoleTesting()
        {
            string application = string.Format("[{0}] {1} {2}", DateTime.Now, shortString, "Window size 800x600");
            string game = string.Format("[{0}] {1} {2}", DateTime.Now, longestString, "vsync = false");
            //Console.WriteLine($"{shortString,10}" + $"{longerString,10}" + $"{longestString,10}");


            Console.WriteLine($"{application,20}");
            Console.WriteLine($"{application,20}");
            Console.WriteLine($"{game,20}");

            //Console.WriteLine($"{shortString,10}");
            //Console.WriteLine($"{longerString,10}");
            //Console.WriteLine($"{longestString,10}");
        }
        //private void Main()
        //{
        //    //ConsoleSpacing console = new ConsoleSpacing();
        //    //console.ConsoleTesting();
        //    //Console.ReadKey();
        //}
    }
}
