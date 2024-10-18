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
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arithmatic operator:+,-,/,%,*

            //calculator:..............................

            /* int number1, number2;
             int result;



             Console.Write($"Enter number1:");
             number1 = Convert.ToInt32(Console.ReadLine());

             Console.Write($"Enter number1:");
             number2 = Convert.ToInt32(Console.ReadLine());


             result = number1 + number2;
             Console.WriteLine("Summation:{0}+{1}= {2}",number1,number2,result);
             Console.WriteLine();
             result = number1 - number2;
             Console.WriteLine($"Substruction:{number1}-{number2}= {result}");
             Console.WriteLine();
             result = number1 * number2;
             Console.WriteLine($"Multiplication:{number1}*{number2}= {result}");
             Console.WriteLine();
             double div = number1 / number2;
             Console.WriteLine($"Division:{number1}/{number2}= {div.ToString("F2")}");
             Console.WriteLine();
             result = number1 % number2;
             Console.WriteLine($"Remainder:{number1}%{number2}= {result}");
             double avg = (number1 + number2)/2;
             Console.WriteLine($"Average:({number1}+{number2})/2)= {avg.ToString("F2")}");

             Console.WriteLine();
            */

            //Triangle area:.....................

            /*int baseLength, heightLength;
            double area;

            Console.Write($"Enter the valu of baseLength:");
            baseLength = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter the valu of heightLength:");
            heightLength = Convert.ToInt32(Console.ReadLine());

           
            area = .5 * baseLength * heightLength;

            Console.WriteLine($"Triangle area:  { area}");
            Console.WriteLine();
            */

            //circle area:....................

            /*int r;
            double area_2;
            Console.Write($"Enter the valu of r:");
            r= Convert.ToInt32(Console.ReadLine());
            area_2 = 3.1416 * r * r;

            Console.WriteLine($"Circle area:  {area_2.ToString("F2")}");
            Console.WriteLine();
            */

            //rectangle area......................

            /*int weigth, height;
            double area_r;

            Console.Write($"Enter the valu of weight:");
            weigth = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter the valu of height:");
            height = Convert.ToInt32(Console.ReadLine());


            area_r = weigth * height;

            Console.WriteLine($"Rectangle area:  {area_r.ToString("F2")}");
         */

            //Temperature:....................

            /*double celcious, fahrenheight;

            Console.Write($"Enter the valu of fahrenheight:");
            fahrenheight= Convert.ToDouble(Console.ReadLine());
            celcious = ((fahrenheight - 32) * 5) / 9;
            Console.WriteLine($"Celcious= {celcious.ToString("F2")}");
            */


            //Square........................
            int a,b;
            double square;


            Console.Write($"Enter the valu of a:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Enter the valu of b:");
            b = Convert.ToInt32(Console.ReadLine());
            square = (a + b)^;
            Console.WriteLine($"Square= {square.ToString("F2")}");

        }
    }
}
           


            
        
    






