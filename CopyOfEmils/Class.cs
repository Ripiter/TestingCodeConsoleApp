using System;
using System.Collections.Generic;


namespace CopyOfEmils
{
    abstract class Class : IShowMenu
    {
        public static Class instance;
        public Class()
        {
            instance = this;
        }
        internal List<Class> classes = new List<Class>();

        public List<Class> IList => classes;

        internal protected abstract void Run();
    }
}
