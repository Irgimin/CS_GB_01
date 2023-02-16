// 5. С клавиатуры вводятся три числа. Найти максимальное из трех чисел

Console.WriteLine("Введите a "); 
int a=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b "); 
int b=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите c "); 
int c=Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
                    Console.WriteLine("Максимальное значение " + a); 
                else if (b > c)
                    Console.WriteLine("Максимальное значение " + b); 
                else
                    Console.WriteLine("Максимальное значение " + c); 