using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCodeConsoleApp
{
    class Dog : Animals
    {
        string name;
        byte age;
        public Dog(string name, byte age) : base(name,age)
        {
            this.name = name;
            this.age = age;
        }

        public override void Sound()
        {
            Console.WriteLine("Bark");
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
