using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class main
    {
        static void Main(string[] args)
        {
            String val;
            int userVal;
            Console.WriteLine("TARUN ANAND GOYAL");
            Console.WriteLine("Patterns Assignments 5th March 2024");

            Console.Write("Enter number of Rows: ");
            val = Console.ReadLine();
            userVal = Convert.ToInt32(val);


            
            Assignmetn1 obj = new Assignmetn1();
            Console.WriteLine("----------------------------------");
            obj.BinaryTriangle(userVal);
            Console.WriteLine("----------------------------------");
            obj.NumberPattern(userVal);
            Console.WriteLine("----------------------------------");
            obj.NumberInc(userVal);
            Console.WriteLine("----------------------------------");
            obj.NumberDec(userVal);
            Console.WriteLine("----------------------------------");
            obj.CounterPyramid(userVal);
            Console.WriteLine("----------------------------------");
            obj.Diamond(userVal);
            Console.WriteLine("----------------------------------");
            obj.Rohmbus(userVal);
            Console.WriteLine("----------------------------------");
            obj.MirrorImage(userVal);
            Console.WriteLine("----------------------------------");
            obj.PalindromeTriangle(userVal);
            Console.WriteLine("-------------------------------------------");
            obj.PascalTriangle(userVal);
            Console.WriteLine("-------------------------------------------");
            obj.SquareHollowPattern(userVal);
            Console.WriteLine("-------------------------------------------");
            obj.HollowHourglassPattern(userVal);
            Console.WriteLine("-------------------------------------------");
            obj.HollowDiamondPyramid(userVal);
            Console.WriteLine("-------------------------------------------");
            obj.HollowReverseTrianglePattern(userVal);
            Console.WriteLine("-------------------------------------------");
            obj.HollowTrianglePattern(userVal);
            Console.WriteLine("-------------------------------------------");
            Console.ReadLine();



        }
    }
}
