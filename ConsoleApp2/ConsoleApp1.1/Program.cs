using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._1
{
    class Sputnik
    {
        private string name;
        private double speed;
        private bool isFly;
        private bool isTranslate;
        private string message;

        public Sputnik()
        {
            name = "Apolon";
            speed = 120;
            isFly = false;
            isTranslate = false;
            message = "Hello World";
        }
        public void GetInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"isFly: {isFly}");
            Console.WriteLine($"isTranslate: {isTranslate}");
            Console.WriteLine($"message: {message}");
        }

        public void GoToSpace()
        {
            if (isFly)
            {
                Console.WriteLine("Нувозможно, мы уже тут ");
            }
            else
            {
                Console.WriteLine("Полетели ");
                isFly = true;
            }
        }

        public void GoToLand()
        {
            if (isFly)
            {
                Console.WriteLine("Вернулись ");
                isFly = true;
            }
            else
            {
                Console.WriteLine("Мы уже тут ");

            }

        }

        public void StartTranslate()
        {
            if (isTranslate)
            {

            }
        }

        public void StopTranslate()
        {
            if (isTranslate)
            {
                Console.WriteLine("Есть остановить трансляцию!");
                isTranslate = false;
            }
            else
            {
                Console.WriteLine("Еще не начали трансляцию!");
            }
        }


        class Program
        {
            static void Main(string[] args)
            {
            }
        }
    }
}
