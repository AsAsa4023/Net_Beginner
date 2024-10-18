using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//type casting

//implecit/automatic convertion: char -> int ->long->float->double ->decimal
//explecit/manual convertion : double->float->long->int->char

//build in method: Convert
namespace Student_Managrment
{
    internal class Type_casting
    {


        static void Main_ty(string[] args)
        {
            //double ->int
            double salary = 2547.89;
            Console.WriteLine(salary);

            int salary2 = (int)salary;
            Console.WriteLine(salary2);

            // int -> char
            int salary1 = 2547;
            Console.WriteLine(salary1);

            char salary3 = (char)salary1;
            Console.WriteLine(salary2);


            //convert method

            int salary4 = 254700000;
            Console.WriteLine(Convert.ToString(salary4));
            Console.WriteLine(Convert.ToDouble(salary4));
            Console.WriteLine(Convert.ToChar(salary4));
            Console.WriteLine(Convert.ToString(salary4));

        }
    }
}
