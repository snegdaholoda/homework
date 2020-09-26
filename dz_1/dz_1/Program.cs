using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        double razmerVklada = 1000;
        int P = 3; //проценты
        double itog; // сколько '+' каждый месяц от вклада 
        int kolmes = 0; // колицество месяцев 


        while (razmerVklada < 1100) 
        {
            kolmes++;
            itog = (razmerVklada * P) / 100;
            razmerVklada = itog + razmerVklada;

        }
        Console.Write("За ");
        Console.Write(kolmes);
        Console.Write(" месяца вклад превысит 1100 руб. и составит ");        
        Console.Write(razmerVklada);
        Console.WriteLine(" руб. ");
    }
}
