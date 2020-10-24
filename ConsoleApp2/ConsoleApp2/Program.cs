using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 10;
            int[] arr = new int[size] { 13,0,12,0,5,10,9,0,6,9 };

            Console.WriteLine("Enter numer in array");
            int n = Convert.ToInt32(Console.ReadLine());
            int res = 0;


            for (int i = 0; i < size; i++)
            {
                if(arr[i] == n)
                {
                    res++;           
                }
            }
            
                Console.WriteLine(res);
            
        }
    }
}
