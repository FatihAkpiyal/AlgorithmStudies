using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUygulamasi.Basics
{
    public class Splitter
    {
        static public void Splittter()
        {
            Console.WriteLine("Please Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i < 3; i++)
            {
                Console.WriteLine($"{a} {a} {a} {a}");
                for(int j = 0; j < i; j++)
                {
                    Console.WriteLine($"{a}{a}{a}{a}");
                    if(j==1)
                    {
                        continue;
                    }
                }
            }
        }
    }
}
