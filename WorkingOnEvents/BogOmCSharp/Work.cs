using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingOnEvents.BogOmCSharp
{
    class Work
    {
        public delegate void DataChangeEvent(object sender, Person per);


        public event DataChangeEvent FirstNameChanged;



        public Work()
        {
            Person p = new Person();

            p.FirstName = "Zeppo";
            p.LastName = "Jojo";
          

            ChangeFirstName(p);
        }

        public void ChangeFirstName(Person per)
        {
            FirstNameChanged(this, per);
        }
    }
}
