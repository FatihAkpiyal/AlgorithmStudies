using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUygulamasi.Basics
{
    public class letterChanger
    {

        static public void LetterChanger(string a )
        {
            Console.Write("Please enter a string: ");
            a = Console.ReadLine();
            

            Console.WriteLine(a.Substring(a.Length - 1) + a.Substring(1, a.Length - 2) + a.Substring(0, 1));
            

        }
    }
}
