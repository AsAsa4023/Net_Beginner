using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Naming convention:
//single word use are pasclase case:name
//myFirstName(camel case)
//Meaning full name use
// avoid single character without loop
//descriptive
namespace Student_Managrment
{
    internal class Assignment_2_naming_conventiom
    {
        static void Main_A2(string[] args)
        {
            string productName = "Apple iphone 14";
            double price = 320.5;
            string productCategory = "Smart phone";
            bool available = true;
            int productSold = 5;
            Console.WriteLine($"Product Name:{productName}");
            Console.WriteLine($"Product price:{price}");
            Console.WriteLine($"productCategory:{productCategory}");
            Console.WriteLine($"Product available:{available}");
            Console.WriteLine($"productSold:{productSold}");


        }
    }
}
