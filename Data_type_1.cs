using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
//data type:

//int=112,-112;
//double = 12.2;
// string =" hellow"
// char = 'a'
//bool = true/false
namespace Student_Managrment
{
    internal class Data_type_1
    {

        static void Maind1(string[] args)
        {
            bool canIVote = true;//boolen
            //integer
            Console.WriteLine("Biggest Integer:{0} ", int.MaxValue);
            Console.WriteLine("Smallers Integer:{0}", int.MinValue);
            Console.WriteLine();

            //long
            Console.WriteLine("Biggest Long: {0}", long.MaxValue);
            Console.WriteLine("Smallest Long: {0}", long.MinValue);
            Console.WriteLine();

            //decimal
          

            Console.WriteLine("Smallest Decimal: {0}", Decimal.MinValue);
            Console.WriteLine("Biggest Decimal: {0}", Decimal.MaxValue);

            decimal decPiVal = 3.14159265358M;
            decimal decBigNum = 3.00000000000000000000011M;
            Console.WriteLine("Dec:PI+bigNum ={0}", decPiVal + decBigNum);

            Console.WriteLine();

            //double
            Console.WriteLine("Biggest double:{0}", Double.MaxValue);

            Console.WriteLine("Smallest double:{0}", Double.MinValue);

            double dbPiVal = 3.14159265358;
            double dbBigNum = 3.00000000000000000000011;
            Console.WriteLine("DBL:PI+bigNum ={0}", dbPiVal + dbBigNum);
            Console.WriteLine();
            //float
            Console.WriteLine("Biggest float:{0}", Double.MaxValue);

            Console.WriteLine("Smallest float:{0}", Double.MinValue);

            float flatPiVal = 3.14159265358F;
            float flatBigNum = 3.00000000000000000000011F;
            Console.WriteLine("FLAt:PI+bigNum ={0}", flatPiVal + flatBigNum);
            Console.WriteLine();

            //other data type

            bool boolFromStr = bool.Parse("true");//bool to string

           int intFromStr = int.Parse("100");//Integer to string

           double doubleFromStr = double.Parse("1234");//double to string

            string strVal = doubleFromStr.ToString();

            Console.WriteLine($"data type:{strVal.GetType()}");
            double dblNum = 12.345;
            Console.WriteLine($"Integer:{(int)dblNum}");
            int intNum = 10;
            long longNum = intNum;

        }


    }
}
