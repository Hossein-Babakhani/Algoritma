using System;

namespace Algoritma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir dize girin: ");
            string str = Console.ReadLine();

            Console.Write("Bir dizin girin:");
            int dizin = Convert.ToInt32(Console.ReadLine());
            
            if (dizin<0 || dizin>=str.Length)
            {
                Console.Write("Geçersiz dizin");
                return;
            }
            string newStr = str.Substring(0, dizin) + str.Substring(dizin + 1);
            Console.WriteLine("Sonuç:" + newStr);
            Console.ReadKey();
        }
    }
}
