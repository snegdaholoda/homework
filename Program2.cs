using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace dz_2._1
{

    class Student
    {
        private string name;
        private string groop;
        private int age;
        int[][] arr = new int[3][];

        public Student(string name, string groop, int age)
        {
            this.name = name;
            this.groop = groop;
            this.age = age;
            arr[0] = new int[] { 2, 5, 7, 10 };
            arr[1] = new int[] { 2, 5, 6 };
            arr[2] = new int[] { 4, 9, 7, 6 };

        }
        
        public void currentAssessment()
        {        
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write($"{arr[i][j]} \t");
                }
                Console.WriteLine();
            }
        }
        public void setAssessment()
        {        
            Console.WriteLine("Хотите поменять текущие оценки? (Y/N)");
   
            string choice = Console.ReadLine();
            
            if (choice == "Y" || choice == "y")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        arr[i][j] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        Console.Write($"{arr[i][j]} \t");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine();
            }         
        }
        public void getAssessment()
        {
            Console.WriteLine("По какому предмету нужно получить оценки? 1.Прогр. 2.Админ. 3.Диз.");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                for (int j = 0; j < arr[0].Length; j++)
                {
                    Console.Write($"{arr[0][j]} \t");
                }                
                    Console.WriteLine();
            }
            else if(choice == 2)
            {
                for (int j = 0; j < arr[1].Length; j++)
                {
                    Console.Write($"{arr[1][j]} \t");
                }
                Console.WriteLine();
            }
            else if (choice == 3)
            {
                for (int j = 0; j < arr[2].Length; j++)
                {
                    Console.Write($"{arr[2][j]} \t");
                }
                Console.WriteLine();
            }
        }
        public void getAverage()
        {
            Console.WriteLine("По какому предмету нужно получить средний балл? 1.Прогр. 2.Админ. 3.Диз.");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                double res = 0;
                int coll = 0;
                for (int j = 0; j < arr[0].Length; j++)
                {
                    res += arr[0][j];
                    coll++;
                }
                res /= coll;
                Console.WriteLine(res);
            }
            else if (choice == 2)
            {
                int res = 0;
                int coll = 0;
                for (int j = 0; j < arr[1].Length; j++)
                {
                    res += arr[1][j];
                    coll++;
                }
                res = res / coll;
                Console.WriteLine(res);
            }
            else if (choice == 3)
            {
                int res = 0;
                int coll = 0;
                for (int j = 0; j < arr[2].Length; j++)
                {
                    res += arr[2][j];
                    coll++;
                }
                res = res / coll;
                Console.WriteLine(res);
            }


        }
        public void studentPrint()
        {
            Console.WriteLine($"ФИО студента: {name}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Группа: {groop}");

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student t = new Student("Лебедев Тимофей", "П22019", 18);
            t.studentPrint();
            t.currentAssessment();

            t.setAssessment();
            t.getAssessment();

            t.getAverage();
        }
    }
}
