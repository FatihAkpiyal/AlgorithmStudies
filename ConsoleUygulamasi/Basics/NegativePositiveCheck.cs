using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUygulamasi.Basics
{
    public class NegativePositiveCheck
    {
        public static void NegPosChecker()
        {
            while (true)
            {
                Console.WriteLine("Please enter a negative num: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter a positive num: ");
                int b = Convert.ToInt32(Console.ReadLine());

                if ((a < 0 || b < 0) && (a > 0 || b > 0))
                {
                    Console.WriteLine("True");
                }   
                else
                {
                    Console.WriteLine("False");
                }
            }
            

        }
    }
}
