using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    internal class CalculatorFunctionality
    {
        public int a { get; set; }
        public int b { get; set; }
        public void Add()
        {
            Console.WriteLine($"\nAddition of two numbers {a} & {b} is {a+b}");
            askexit();
        }

        public void Sub()
        {
            Console.WriteLine($"\nSubstraction of two numbers {a} & {b} is {a - b}");
            askexit();
        }

        public void Mul()
        {
            Console.WriteLine($"\nMultiplication of two numbers {a} & {b} is {a * b}");
            askexit();
        }

        public void Div()
        {
            Console.WriteLine($"\nDivision of two numbers {a} & {b} is {a / b}");
            askexit();
        }
        public void askexit()
        {
            var back = "back";
            do
            {
                Console.WriteLine("\nPress enter to go to Main Menu");
                back = Console.ReadLine();
            }
            while (back != "");
        }
    }
}
