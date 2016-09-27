using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Ch03_Excercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {


                try
                {
                    int max = 500;
                    for (byte i = 0; i < max; i++)
                    {
                        WriteLine(i);
                    }
                }
                catch (OverflowException)
                {

                    WriteLine("OverFlow detected");
                }
            }

        }
    }
}
