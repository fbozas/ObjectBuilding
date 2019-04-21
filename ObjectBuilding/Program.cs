using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// How we can build an object? Let's build an object for a customer with three different ways
namespace ObjectBuilding
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: The first thing we have to do is to create a customer class
            // So click on ObjectBuilding project on your solution explorer,
            // press right click and click "add class". Go to customer class now for the 2nd step 

            // Now let's see how we can make objects this is the 1st way by using default constructor
            Customer customer1 = new Customer();
            customer1.FirstName = "Nick";
            customer1.LastName = "Giannou";
            customer1.Reliable = true;
            customer1.Weight = 72.3f;
            customer1.DateOfBirth = new DateTime(1990,2,3);

            //This is the 2nd way by using default constructor
            // (Don't forget commas between the properties)
            Customer customer2 = new Customer()
            {
                FirstName = "Giannis",
                LastName = "Eleftheratos",
                Reliable = true,
                Weight = 68.6f,
                DateOfBirth = new DateTime(1991, 3, 7)
            };

            // This is the 3d way (and the fastest ;) ) by using the constructor we created
            Customer customer3 = new Customer("George", "Papadopoulos", false, 66.9f, new DateTime(1993, 5, 2));

            Console.WriteLine(customer1);
            Console.WriteLine(customer2);
            Console.WriteLine(customer3);
        }
    }
}
