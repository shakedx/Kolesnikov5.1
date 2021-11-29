using System;

namespace Kolesnikov5._1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите строку: ");
            string a = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите символ для нахождения: ");
            string b = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите второй символ для нахождения: ");
            string c = Convert.ToString(Console.ReadLine());
            int str1 = 0, index = 0, str2 = 0;
            while ((index = a.IndexOf(b, index) + 1) != 0) str1++;
            while ((index = a.IndexOf(c, index) + 1) != 0) str2++;
            Console.WriteLine("Символ " + b + " встречается в тексте -> " + str1 + " раз(а)");
            Console.WriteLine("Символ " + c + " встречается в тексте -> " + str2 + " (а)");
            Console.ReadKey();
        }
    }
}