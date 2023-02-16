// 13. Удалить вторую цифру целого числа введенного с клавиатуры.

System.Console.Write("Введите значение: ");
int N=Convert.ToInt32(Console.ReadLine());
int counterDigit=0;
int N1=N;
while(N!=0)
{
    counterDigit++;
    N/=10;
}
int d=N1/(int)Math.Pow(10,counterDigit-2)%10;    // в степени
int d1=N1/(int)Math.Pow(10,counterDigit-1)%10;
int n2=N1%(int)Math.Pow(10,counterDigit-2);
System.Console.WriteLine(d1+""+n2);