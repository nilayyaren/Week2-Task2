using System;

namespace Week2_Tas2
{
    class Program
    {
        public static double Process(int a, int b, char c)
        {
            if (c == '+')
            {
                return a + b;
            }
            else if(c == '-')
            {
                return a - b;
            }
            else if(c=='*')
            {
                return a * b;
            }
            else if(c=='/')
            {
                return 1.0f*a / b;
            }
            else
                return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("choose the operator: '+' , '-' , '*' , '/'");
            char c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(Process(a, b, c));
            Console.ReadLine();
        }
    }
}
