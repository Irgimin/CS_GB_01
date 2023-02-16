// 14. С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.

System.Console.Write("Введите значение a: ");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите значение b: ");
int b=Convert.ToInt32(Console.ReadLine());

while(a>=b)
{
    if (a!=0)    
    a=a-b;
}

if(a==0)
System.Console.WriteLine("a кратно b");
else
System.Console.WriteLine("a не кратно b");
System.Console.WriteLine("Остаток деления:" +a);
