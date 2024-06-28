using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUygulamasi.Basics
{
    public class MultiplierTable
    {
        static public void calculator()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int result;

            for (int i = 0; i <= 10; i++)
            {
                result = a * i;
                Console.WriteLine($"{a}*{i}={result}");
            }
        }
    }
}
