using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace dz_1._4
{
    class Program
    {
        static void Main(string[] args)
        {

            string str;

            str = (Console.ReadLine());

            int strLen = str.Length;

            for(int i = 0; i < strLen/2; i++)
            {
                if(str[i] != str[strLen - i - 1])
                {
                    Console.WriteLine("Число не являеться палиндромом");
                    break;
                }
                else
                {
                    Console.WriteLine("Число являеться палиндромом");
                }
            }
           
        }
            
    }

}

