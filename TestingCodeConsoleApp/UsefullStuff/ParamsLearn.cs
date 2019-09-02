using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCodeConsoleApp.UsefullStuff
{
    class ParamsLearn
    {
        public void Starter(params string[]  a)
        {
            Console.WriteLine("string");
            if(a.Length == 0)
                Console.WriteLine("a is empty");
            

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
        public void Starter(params object[]  a)
        {
            Console.WriteLine("object");
            if(a.Length == 0)
                Console.WriteLine("a is empty");
            

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i].ToString());
            }
        }
    }
}
