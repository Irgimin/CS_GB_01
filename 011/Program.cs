// 11.Дано число больше 9. Вывести на экран  вторую цифру числа с конца

System.Console.Write("Введите число больше девяти: ");
int n=Convert.ToInt32(Console.ReadLine());
int d0,d1,d2;
d0=n%10;
d1=n/10%10;
d2=n/100;
if(n>9)
System.Console.WriteLine($"{d1}");
else
System.Console.Write("Вы ввели мало символов");