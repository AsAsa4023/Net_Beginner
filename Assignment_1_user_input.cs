using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Managrment
{
    internal class Assignment_1_user_input
    {



        static void Main_ui(string[] args)
        {
            string name, message;
            int age;
            Console.Write($"My Name is:");
            name =Convert.ToString( Console.ReadLine());
           

            Console.WriteLine($"Age:");
            age = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"Message:");
            message = Convert.ToString(Console.ReadLine());

            Console.WriteLine($"name:" + name);
            Console.WriteLine($"Age:" + age +"years old");// string concetanatiom
            Console.WriteLine($"message:" + message);
        }

    }
}
