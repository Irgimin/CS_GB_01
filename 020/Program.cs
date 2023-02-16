// 20. Дано число. Проверить кратно ли оно 7 и 23

using System;
 
namespace Test
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
 
            if (n % 7 == 0 && n % 23 == 0)
                Console.WriteLine("Число кратно 7 и 23.");
            else if(n % 7 == 0)
                Console.WriteLine("Число кратно 7.");
            else if(n % 23 == 0)
                Console.WriteLine("Число кратно 23.");
            else
                Console.WriteLine("Число не кратно 7 и 23.");
        }
    }
}
