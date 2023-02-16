// 12. С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа

using System;
 
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, max = 0;
            System.Console.WriteLine("Введите число: ");
            n = int.Parse(System.Console.ReadLine());
            while (n > 0)
            {
            if (max < n % 10) max = n % 10;
            n /= 10;
            }
        if (max>9 || max<100)
        System.Console.WriteLine(max);
        else
        System.Console.WriteLine("Вы ввели неверные данные");
        }
    }
}



// Console.Write("Введите число от 10 до 99 : ");
// Console.WriteLine("Ответ = {0}", Console.ReadLine().ToArray().Max() - '0');



// int n=123465723;
// int max;
// for(max=0; n>0; n/=10)
// {
//    int a=n%10;
//    if(max<a) max=a;
// }
// Console.WriteLine(max);


//неверное решение
// int N=48;
// int d1=N/10;
// int d2=N/10;
// int max=d1;
// if (d2>max) max=d2;
// System.Console.WriteLine(max);