using System;
using System.Collections.Generic;

namespace WorkingOnEvents.BogOmCSharp
{
    public class Person 
    {
        public event EventHandler firstNameChanged;
        public event EventHandler EfternavnNameChanged;

        private string firstName;
        private string lastName;

       

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
                firstNameChanged(this, new EventArgs());
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {     
                lastName = value;
            }
        }

    }

    

}
