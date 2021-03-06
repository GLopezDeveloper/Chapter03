﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Ch03_SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length == 0)
            {
                WriteLine("There are no arguments.");
            }
            else
            {
                WriteLine("There is at least one argument.");
            }

        A_label:

            var number = (new Random()).Next(1, 7);
            WriteLine($"My random number is {number}");
            switch (number)
            {
                case 1:
                    WriteLine("One");
                    break;
                case 2:
                    WriteLine("Two");
                    goto case 1;
                case 3:
                case 4:
                    WriteLine("Three or four");
                    goto case 1;
                case 5:
                    System.Threading.Thread.Sleep(500);
                    goto A_label;
                default:
                    WriteLine("Default");
                    break;
            }

            var x = 3;
            if (x == 3)
            {
                WriteLine("three");
            }

        }
    }
}
