using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//variable: digit ,Letter,_ are use
//can not start with digit,and space not allow,keywords not use

namespace Student_Managrment
{
    internal class Variable_data_type_2
    {

        static void Main_dv2(string[] args)
        {
            //variable

            string firstName;//camelcase
            string lastName;//camelcase
            string fullName;//convention
            firstName = "Aysha ";
            lastName = "Siddika";
            fullName = firstName + " " + lastName;
            Console.WriteLine($"fullName: {fullName}");

            ////data type

            int age = 30;
            double gpa = 3.41;
            bool isRegister = true;
            char bloodGroup = 'A';
            Console.WriteLine($"Age:{age}");
            Console.WriteLine($"Gpa: {gpa}");
            Console.WriteLine($"isRegister: {isRegister}");
            Console.WriteLine($"Blood Group: {bloodGroup}");


            //const variable
            const string bachelorUniversityName = "Dhaka University of Engineernig And technology";// const use bcz any person can not change this variable and must be assign value
            Console.WriteLine(bachelorUniversityName);
            //multiple variable

            int number1;
            int number2;
            int number3;

            number1 = 10;
            number2 = 20;
            number3 = 30;

            int number4 = 10, number5 = 20, number6 = 30;

            Console.WriteLine(number1);

            //Parse method are use when string are used
            string number = "10";
            int number7 = int.Parse(number);

            Console.WriteLine($"Number2:{number}");

            // TryParse.....

            string input = "10.5";
            bool isSuccess = int.TryParse(input, out int result);// TryParse can exception handeling

            Console.WriteLine($"Number2:{result}");

            Console.WriteLine($"isSuccess :{isSuccess}");
        }


    }
}
