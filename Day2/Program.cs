using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Operatiors

            // data -> information

            // Assignment Operator
            // =, +=, -=

            // Arithmatic Operators
            // +,-,*,/,%

            // Comparison Operators
            // >, <, >=, <=, ==

            // Logical Operators
            // AND (&&) , OR (||), NOT(!)

            // Decision Making
            // (if-else) (switch)

            // Can be vote.
            // Can't vote.
            /*
            Console.Write("Enter Your Nationality: "); 
            string nat = Console.ReadLine();
            Console.Write("Enter your age: ");
            // int age = int.Parse(Console.ReadLine());
            int age = Convert.ToInt32(Console.ReadLine());

            if (nat.ToLower() == "mm" && age >= 18) // True
            {
                Console.WriteLine("Can be vote.");
            }
            else 
            {
                Console.WriteLine("Can't vote.");
            }
            */

            /*
            int marks = 65;
             
            if (marks>=50)
            {
                if (marks >= 65 && marks < 85)
                    Console.WriteLine("Pass with Cridit");
                else if (marks >= 85)
                    Console.WriteLine("Pass with D");
                else
                    Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Failed");
            }
            */

            /*
            int cardNo = 11;

            if (cardNo == 11)
            {
                Console.WriteLine("Jack")
            }
            else if (cardNo == 12)
            {
                Console.WriteLine("Queen");
            }
            else if (cardNo == 13)
            {
                Console.WriteLine("King");

            }
            else
            { Console.WriteLine("Plain Card"); 
            }

            switch (cardNo)
            {
                case 11:
                    Console.WriteLine("Jack");break;
                case 12:
                    Console.WriteLine("Queen"); break;
                case 13:
                    Console.WriteLine("King"); break;
                default:
                    Console.WriteLine("Plain Card"); break;
            }
            */

            int daysOfMonth = 9, year = 2024;

            if (daysOfMonth == 2)
            {
                if (year % 4 == 0)
                {
                    Console.WriteLine("29 Days");
                }
                else
                {
                    Console.WriteLine("28 Days");
                }
            }
            else if (daysOfMonth == 4 || daysOfMonth == 6 || daysOfMonth == 9 || daysOfMonth == 11)
            {
                Console.WriteLine("30 Days");
            }
            else
            {
                Console.WriteLine("31 Days");
            }

            switch(daysOfMonth)
            {
                case 2:
                    Console.WriteLine("28 Days");break;
                case 4: case 6: case 9: case 11:  // stacking case
                    Console.WriteLine("30 Days");break;
                default:
                    Console.WriteLine("31 Days");break;

            }


            // A, B, AB, o
            // A and A => A, o
            // A and B => ALL
            // A and AB=> A,B,AB
            // A and O => A, o

            Console.Write("Enter Your Father Blood Group: ");
            string P1 = Console.ReadLine();
            Console.Write("Enter Your Mother Blood Group: ");
            string P2 = Console.ReadLine();

            if (P1 == "A" && P2 == "A")
            {
                Console.WriteLine("Possible Child's Blood Group is 'A' or 'O'");
            }
            else if (P1 == "A" && P2 == "B")
            {
                Console.WriteLine("Possible Child's Blood Group is ALL : A,B,AB & O");
            }
            else if (P1 == "A" && P2 == "AB")
            {
                Console.WriteLine("Possible Child's Blood Group is A,B & AB");

            }
            else if (P1 == "A" && P2 == "O")
            {
                Console.WriteLine("Possible Child's Blood Group is A,B & AB");

            }
            else
            {
                Console.WriteLine("Not in Blood Group");
            }



        }
    }
}
