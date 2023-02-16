// 26. Программа проверяет пятизначное число на палиндромом. Например:12321

using System;
    class Palindr
     {
        public static bool Palindromtest (string s)
        {
            for (int i = 0, j = s.Length - 1; i < j; i++, j--)
                if (s[i] != s[j])
                    return false;
                    return true;
 
        }
     
    static void Main()
        {
        string s;
            Console.WriteLine("Анализ палиндромов\n\nВведите строку:");
            s = Console.ReadLine();
            if (Palindromtest(s))
    Console.WriteLine("Эта строка - палиндром");
    else Console.WriteLine("Эта строка - не палиндром");
    }
}