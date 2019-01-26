using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstClassApp
{
    class Human
    {
        //Default Construstor
        public Human() { }

        //Constructor overload that requires first and last name
        public Human(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }
        public string HairColour { get; set; }
        public double Weight { get; set; }

        //FullName property that only returns (getter) a value, 
        //but doesnt allow a set. 
        public string FullName {
            get { return FirstName + " " + LastName; }
        }
    }
}
