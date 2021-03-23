using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleConsoleApp
{
    class Dave
    {
        public string FirstName { get; set; }

        public string Surname { get; set; }

        public Dave(string firstName, string surname)
        {
            FirstName = firstName;
            Surname = surname;
        }
    }
}
