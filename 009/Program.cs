// 9.Вывести на экран четные числа от 1 до N
int i=2;
System.Console.Write("Введите значение: ");
int N=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Четные числа:");
while(i<=N)
{
    System.Console.WriteLine(i);
    i=i+2;
}