// 51. С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры
// Определить сколько чисел больше 0 введено с клаиватуры
// Игра с пространством имен


namespace GB
{
    namespace intro
    {
        class T051
        {
            static void Main()
            {
                int N=Convert.ToInt32(Console.ReadLine());
                int k=0;
                for(int i=0;i<N;i++)
                {
                    int n=int.Parse(Console.ReadLine());
                    if (n>0) k++;
                }
                System.Console.WriteLine(k);
                // GB.intro.T051.Main();
            }
        }

    }

}