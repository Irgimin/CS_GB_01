// 24. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

using System;

namespace Test
{
    class Programm
    {
            static void Main(string[] args)
            {
                Console.WriteLine("Введите x: ");
                double x = Convert.ToDouble(Console.ReadLine());
 
                Console.WriteLine("Введите y: ");
                double y = Convert.ToDouble(Console.ReadLine());
 
                if (x > 0 && y > 0)
                    Console.WriteLine("I четверть");
                else if (x > 0 && y < 0)
                    Console.WriteLine("IV четверть");
                else if (x < 0 && y > 0)
                    Console.WriteLine("II четверть");
                else if (x < 0 && y < 0)
                    Console.WriteLine("III четверть");
                else if (x == 0 || y == 0)
                    Console.WriteLine("Точка является началом координат или лежит на одной из осей x или y");  
 
            Console.ReadLine();
        }
    }
}
