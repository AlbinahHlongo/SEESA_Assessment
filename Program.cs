using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEESA_Assessment
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
               // string print = "";
               if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                  //  print = " Fizz";
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                   // print = i + " Buzz";
                }
                else if (i % 3 == 0 && i % 5 == 0) 
                {
                    Console.WriteLine("FizzBuzz");
                  //  print = " FizzBuzz";
                }

                else
                {
                    Console.WriteLine(i);
                }            }
            Console.ReadLine();
        }
    }
}
