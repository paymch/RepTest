using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string enterString = Console.ReadLine();
            char[] charArray = enterString.ToCharArray();
            bool check = true;


                for (int i = 0; i < enterString.Length; i++)
                {
                
                   
                        switch (enterString[i])
                         {
                             case '(':
                                if (enterString[i + 1] == ')' || enterString[enterString.Length - 1 - i] == ')')
                                { }
                                else check = false;
                                break;
                            case '{':
                                if (enterString[i + 1] == '}' || enterString[enterString.Length - 1 - i] == '}')
                                { }
                                else check = false;
                                break;
                            case '[':
                                if (enterString[i + 1] == ']' || enterString[enterString.Length - 1 - i] == ']')
                                { }
                                else check = false;
                                break;


                        }

                   
                  
                   
                   

                }

            Console.WriteLine("Строка: " + check);
            Console.Read();
                

            
        }
    }
}
