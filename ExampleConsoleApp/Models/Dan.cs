using System;

namespace ExampleConsoleApp.Models
{
    public class Dan
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName {
            get {
                return this.FirstName+" ".this.LastName;
            }
        }

        public Dan(string fName, string lName)
        {

            this.FirstName = fName;
            this.LastName = lName;

        }

    }
}
