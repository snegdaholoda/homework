using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();



            while (a <= b)
            {

                for (int i = 0; i < a; i++)
                {
                    Console.Write(a);
                }       
                
                Console.WriteLine();
                a++;
            }

        }
    }
}
