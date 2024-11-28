using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Welcome to ITC");

            // Literals
            // Number,Words,Decision,Date&Time

            // Numbers
            // Integer,Decimal,Real,Rational,Prime
            // Constant,Variable

            // Name

            // Variable Declaration

            // string, char

            string name = "Ko Aye"; // Ko Aye (string literal)
            name= "Ko Phyu"; // Ko Phyu

            char vowel = 'e'; // char literal

            Console.WriteLine(name);

            // byte, sbyte
            // short, ushort
            // int, uint (32 bits)
            // long, ulong (64 bits)

            // byte -> 8 bits -> 0 to 255 (only +kaepyae) (2P0 to 2P7(128))
            // sbyte-> 8 bits -> -128 to 127 (can +kaepyae & also -kaepyae)

            // short-> 16 bits-> -32768 to 32767
            // ushort->16 bits-> 0 to 65535

            byte age = 18;
            byte day = 24;

            Console.WriteLine(age);
            Console.WriteLine(day);

            // double,float,decimal (27)

            double dou = 10.123;
            float flo = 10.123f;
            decimal dec = 10.123m; // 128 bits

            Console.WriteLine(dou);
            Console.WriteLine(flo);
            Console.WriteLine(dec);

            // bool
            bool bo = true;

            Console.WriteLine(bo);

            // DateTime
            DateTime today = DateTime.Now.Date;
            Console.WriteLine(today.ToString("dd/MM/yy"));







        }
    }
}
