// 10. Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 

System.Console.Write("Введите число: ");
int n=Convert.ToInt32(Console.ReadLine());
int d0,d1,d2;
d0=n%10;
d1=n/10%10;
d2=n/100;
System.Console.WriteLine(d0);