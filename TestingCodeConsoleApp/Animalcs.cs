using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCodeConsoleApp
{
    class Animals
    {
        string name;
        byte age;

        public Animals(string name, byte age)
        {
            this.name = name;
            this.age = age;
        }

        public virtual void Sound()
        {
            Console.WriteLine("Sound");
        }

        public override string ToString()
        {
            return $"Dogs name is {name} and he is {age} old";
        }


    }
}
