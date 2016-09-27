using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch_03Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 100;
            for (int i = 1; i <= max; i++)
            {

                if (i % 3 == 0 & i % 5 == 0)
                {
                    Write($"FizzBuzz,");

                }
                else
                {
                    if (i % 5 == 0)
                    {
                        Write($"Buzz,");

                    }
                    else
                    {
                        if (i % 3 == 0)
                        {
                            Write($"Fizz,");

                        }
                        else
                        {
                            Write($"{ i},");
                        }

                    }


                }



            }
        }
    }
}
