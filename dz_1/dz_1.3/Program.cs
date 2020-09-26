using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_1._3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите N");
            int N;
            N = Convert.ToInt32(Console.ReadLine());
            string obr = null;

            while (N > 9)
            {
                obr += (N % 10);
                N = N / 10;
            }

            obr += N;
            Console.WriteLine("Число наоборот " + obr);


        }
    }
}
