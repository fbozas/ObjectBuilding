using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectBuilding
{
    class Customer
    {
        // Step 2 Now we have to create our properties..
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Reliable { get; set; }
        public float Weight { get; set; }
        public DateTime DateOfBirth { get; set; }

        // Step 3.A Now we have to write our default constructor. This constructor is already used 
        // even though there is no need to write it. We write it now because we also want to use both default
        // and custom constructor. If we delete the default constructor customer1 and customer2 object
        // will shout "Hey I want my parameters inside my paretheses"

        public Customer() // <-- This is the default constructor
        {
                
        }

        // Step 3.B Now we have to create our custom constructor in order to create an object in one line
        // What if our properties didn't start with capital letter? see second version
        public Customer(string firstName, string lastName, bool reliable, float weight, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            Reliable = reliable;
            Weight = weight;
            DateOfBirth = dateOfBirth;
        }

        // Step 4 now we have to create ToString() method in order to print a whole object like this:
        // Console.WriteLine(customer1), not like this Console.WriteLine(customer1.FirstName)
        // Without ToString() method we would need too many Console.WriteLine() methods to print each property
        public override string ToString()
        {
            return "Customer's name is: " + FirstName + " " + LastName + " his/her reliability is: " + Reliable + " his/her weight is: " + Weight + " and his/her date of birth is on: " + DateOfBirth; 
        }
    }
}
