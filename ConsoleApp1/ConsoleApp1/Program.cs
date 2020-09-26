using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
         {

            int a, b, c;

            Console.WriteLine("Введите числа: ");


            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            while (a <= 0 || b <= 0 || c <= 0) 
            {
                if(a <= 0)
                {
                    Console.Write("A меньше нуля ");
                    a = Convert.ToInt32(Console.ReadLine());
                    
                }
                else if(b <= 0)
                {
                    Console.Write("B меньше нуля ");
                    b = Convert.ToInt32(Console.ReadLine());

                }
                else if (c <= 0)
                {
                    Console.Write("С меньше нуля ");
                    c = Convert.ToInt32(Console.ReadLine());
                }
               
            }
        
            int storona1 = a / c;
            int storona2 = b / c;
            int res = storona1 * storona2;


            Console.WriteLine();
            Console.WriteLine(res);
            Console.WriteLine("helo");
        }
        
    }

}

