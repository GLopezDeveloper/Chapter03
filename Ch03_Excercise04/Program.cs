using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch03_Excercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int one;
                int two;
                int result;
                WriteLine("Enter a number between 1 and 255");
                one = Convert.ToInt32( ReadLine());
                WriteLine("Enter another number between 1 and 255");
                two =Convert.ToInt32(ReadLine());
                result = one / two;
                WriteLine($"{one} divide by {two} is {result}");
            }
            catch (FormatException)
            {

                WriteLine("Input string was not in a correct format.");
            }



        }
    }
}
