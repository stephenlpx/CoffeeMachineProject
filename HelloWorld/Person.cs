using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: 
// could add a voucher system where user can get discount on coffees

namespace HelloWorld
{
    public class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }


        public string FullName ()
        {
            return string.Format("{0} {1}", this.firstName, this.lastName);
        }

        public Person(string firstName, string lastName )
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

    }

}
