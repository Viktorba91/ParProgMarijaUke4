using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPUke4Marija
{
    internal class StoreSetup
    {
        public Store MyStore { get; set; }

        //Rydde kode i morgen!

        // Legge inn items pluss antall på lager(?)

        // Bytte til en kunde som har empty shopping cart og skal handle i butikken

        // Items skal ha arv

        public Store CreateShop()
        {
            Console.WriteLine("Welcome to your new store!");

            // Name the store
            Console.WriteLine("Please enter a name for your new store:");
            string ChosenStoreName = Console.ReadLine();

            // Store Type
            Console.WriteLine("What type of store is it?");
            string StoreType = Console.ReadLine();

            MyStore = new Store(ChosenStoreName, StoreType); 

            EmployeeSetup();
            return MyStore;
        }


        // ------------------ Employees Setup --------------------
        public void EmployeeSetup()
        {
            int employeeIndex = 0;
            string employeeName = "";
            string employeePosition = "";
            int employeeAge = 0;

            // Number of employees
            Console.WriteLine("How many employees work at your store?");
            int NumberOfEmployees = int.Parse(Console.ReadLine());


            //Add amount of employees to work at the store:

            while (employeeIndex < NumberOfEmployees)
            {

                //Name
                Console.WriteLine("What is the name of your employee?");
                employeeName = Console.ReadLine();

                //Age
                Console.WriteLine($"Enter {employeeName}'s age:");
                employeeAge = int.Parse(Console.ReadLine());

                //Position
                Console.WriteLine($"What's {employeeName}'s position?");
                employeePosition = Console.ReadLine();

                MyStore.Employees.Add(new Employee(employeeName, employeeAge, employeePosition));
                employeeIndex++;

                Console.Clear();
                GetEmployeeList(MyStore);

            }

            var itemSetup = new ItemSetup();
            itemSetup.ProductSetup(MyStore);
        }
        // ---------------------------------------------------------

        public void GetEmployeeList(Store MyStore)
        {

            Console.WriteLine("Your store is of type: " + MyStore.StoreType);
            Console.WriteLine("All employees have been registered. Here is a list of them:");
            foreach (var user in MyStore.Employees)
            {
                Console.WriteLine(user.Name + " | " + user.Age + " | " + user.Position);
            }

        }
        



    }
}
