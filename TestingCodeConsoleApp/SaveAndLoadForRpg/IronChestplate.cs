using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingCodeConsoleApp
{
    class IronChestplate : Item
    {
        public int BoostHp { get; set; }
        public IronChestplate(string name) : base(name)
        {
            DoSomeCalculations();
        }

        private void DoSomeCalculations()
        {
            BoostHp = 5;
        }
    }
}
