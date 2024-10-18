using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Managrment
{
    internal class Assignment_3_convert
    {

        static void Main_cov(string[] args)
        {

            string name, message;
            int age;
            double gpa;
            bool isRegister;
            Console.Write($"My Name is:");
            name = Convert.ToString(Console.ReadLine());

            Console.Write($"Gpa:");
            gpa = Convert.ToDouble(Console.ReadLine());


            Console.Write($"Age:");
            age = Convert.ToInt16(Console.ReadLine());

            Console.Write($" Have you Register:");
            isRegister = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine($"Message:");
            message = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"name:" + name);
            Console.WriteLine($"Age:" + age + "years old");// string concetanatiom
            Console.WriteLine($"Gpa:" + gpa);
            Console.WriteLine($"All ready Register:" + isRegister);
            Console.WriteLine($"message:" + message);



        }
    }
}
