

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator Application...!");
            int option = 0;
            do
            {
                Console.Clear();
                var a = 0;
                var b = 0;
                Console.WriteLine("---Choose the Option---\n1.Add\n2.Substract\n3.Multiply\n4.Divide\n9.Exit\n :");
                option=int.Parse(Console.ReadLine());
                Console.Clear();
                if (option==9)
                {
                    break;
                }
                Console.Write("Enter the First Number : ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Enter the Second Number : ");
                b = int.Parse(Console.ReadLine());
                CalculatorFunctionality cf = new CalculatorFunctionality { a = a, b = b };

                switch (option)
                {
                    case 1:
                        cf.Add();
                        break;
                        
                    case 2:
                        CalculatorFunctionality cf1 = new CalculatorFunctionality { a = a, b = b };
                        cf.Sub();
                        break;
                    case 3:
                        CalculatorFunctionality cf2 = new CalculatorFunctionality { a = a, b = b };
                        cf.Mul();
                        break;
                    case 4:
                        CalculatorFunctionality cf3 = new CalculatorFunctionality { a = a, b = b };
                        cf.Div();
                        break;
                    default:
                        Console.WriteLine("Enter The Right Option..!");
                        break;
                }

            }while(option!=9);
            Console.WriteLine("Thank You, Visit Again...!");
        }
    }
}
