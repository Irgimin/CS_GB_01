// 2. С клавиатуры вводятся два вещественных числа. Проверять является ли одно из них квадратом второго

int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());

if (a*a==b)
    System.Console.WriteLine("b является квадратом a");
if (b*b==a)
    System.Console.WriteLine("a является квадратом b");