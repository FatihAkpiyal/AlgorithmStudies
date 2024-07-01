using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUygulamasi.AlgorithmExamples
{
    public class StringProblems
    {

        public static void StringLength(string text)
        {
            int counter = 0;
            foreach (char c in text)
            {
                counter++;
            }
            Console.WriteLine(counter);
        }

        public static void StringReverser(string text)
        {
            
            int length = text.Length-1;

            while (length >= 0)
            {
                Console.Write("{0}", text[length]);
                length--;
            }
        }
        
        public static void WordCounter(string text)
        {
            int counter = 0;

            foreach (char c in text)
            {
                if(c == ' ') counter++;
            }
            Console.WriteLine(counter);
        }

        public static void LetterCounter(string text)
        {
            int counter = 0;

            foreach (char c in text)
            {
                if (c == ' ') counter++;
            }
            Console.WriteLine(counter);
        }



    }
}
