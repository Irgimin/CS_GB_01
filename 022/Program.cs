// 22. По двум заданным числам проверять является ли одно квадратом другого.

using System;
 
namespace Test
{
    class Program
    {
        static void Main()
        {
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());

            if (a*a==b)
                Console.WriteLine("b является квадратом a");
            else if (b*b==a)
                Console.WriteLine("a является квадратом b");
            else
                Console.WriteLine("ни одно из чисел не являются квадратом другого числа.");
        }
    }
}