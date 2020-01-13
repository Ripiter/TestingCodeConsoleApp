using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkingOnEvents.BogOmCSharp;
namespace WorkingOnEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            p.firstNameChanged += p_FornavnRettet;
            p.EfternavnNameChanged += P_EfternavnNameChanged;

            //Some big method on some thread
            p.FirstName = "Zeppo";
            p.LastName = "JoJo";

            Console.ReadKey();
        }

        private static void P_EfternavnNameChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Last name changed");
        }

        static void p_FornavnRettet(object sender, EventArgs e)
        {
            Console.WriteLine("First name changed");
        }

    }
}
