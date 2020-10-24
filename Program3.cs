using System;

using System.Linq;


namespace dz_3
{
    class Student
    {
       static void Main(string[] args)
       {
           Ukraine.Kiev ob1 = new Ukraine.Kiev(2884000);
           Russia.Moscow ob2 = new Russia.Moscow(11920000);
           Belarus.Minsk ob3 = new Belarus.Minsk(1975000);
          
           Console.WriteLine("The population of Kiev is {0} inhabitants.\n", ob1.Population);
           Console.WriteLine("The population of Moscow is {0} inhabitants.\n", ob2.Population);
           Console.WriteLine("The population of Minsk is {0} inhabitants.\n", ob3.Population);
                    
       }       

    }
}
