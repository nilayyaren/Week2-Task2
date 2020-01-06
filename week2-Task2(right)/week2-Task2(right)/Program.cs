using System;

namespace Week2_Tas2
{
    class Program
    {
        public static double Process(int a, int b, char choice)
        {
            switch (choice)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    return 1.0f*a / b;
                default:
                    return 0;
                    break;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("choose the operator: '+' , '-' , '*' , '/'");
            char choice = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(Process(a,b,choice));
            Console.ReadLine();
        }
    }
}

