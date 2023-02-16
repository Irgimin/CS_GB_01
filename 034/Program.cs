// 34. Определить количество цифр в числе. Сделать подпрограмму.

int count(int n)
{
    if (n==0) return 1;

    int counter=0;
    while(n!=0)
    {
        counter++;
        n/=10;  //n=n/10
    }
    return counter;
}
System.Console.WriteLine(count(123));
System.Console.ReadLine();