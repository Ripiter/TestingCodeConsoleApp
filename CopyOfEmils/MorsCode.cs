using System;
using System.Collections.Generic;

namespace CopyOfEmils
{
    class MorsCode : Class
    {
        
        public MorsCode()
        {
            this.classes.Add(this);
        }

        internal protected override void Run()
        {
            Console.WriteLine("morse code run");
        }


    }
}
