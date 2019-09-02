using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingOnEvents
{
    public delegate string FirstDelegate(int x);

    class DelegatesValues
    {
        string name;


        void Boy()
        {
            FirstDelegate d1 = new FirstDelegate(StaticMethod);
            

            Console.WriteLine(d1(10)); // Writes out "Static method: 10"
        }

        string StaticMethod(int i)
        {
            return string.Format("Static method: {0}", i);
        }

      
    }
}

