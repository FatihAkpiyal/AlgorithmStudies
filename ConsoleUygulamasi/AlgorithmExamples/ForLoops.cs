using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUygulamasi.AlgorithmExamples
{
    public class ForLoops
    {
        
        public static void TriangleNums()
        {
            for(int i = 2; i < 7; i++)
            {
                for(int j =1; j< i; j++)
                {
                    Console.Write(j);
                }
                Console.Write("\n");
            }
        }

        public static void TriangleNumsSort()
        {
            for (int i = 1; i < 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.Write("\n");
            }
        }

        public static void TriangleIncrease()
        {

            int k = 1;
            for (int i = 1; i < 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("{0} ",k++);
                    
                }
                Console.Write("\n");
            }
        }
    }
}
