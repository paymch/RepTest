using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тестовое_задание
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Напишите входную строку: ");
            string enterString = Console.ReadLine();
            enterString= enterString.ToLower();
            char[] charArray = enterString.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (enterString.Count(x => x == charArray[i]) >= 2) 
                {
                    charArray[i] = ')';

                } else charArray[i] = '(';

            }

            Console.WriteLine(charArray);
            Console.Read();
        }
    }
}
