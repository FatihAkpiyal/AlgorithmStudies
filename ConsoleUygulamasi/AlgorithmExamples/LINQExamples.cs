using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUygulamasi.AlgorithmExamples
{
    public class LINQExamples
    {

        public static void BeginEndWithLinq(string[] text, string l1, string l2)
        {
            
            var words = from x in text
                        where x.StartsWith(l1) && x.EndsWith(l2)
                        select x;

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

        }

        public static void GreaterThanEightee(int[] numbers)
        {

            var greater = from x in numbers
                        where x>80 
                        select x;

            Console.WriteLine("The numbers greater than 80 are: ");
            foreach (var num in greater)
            {
                Console.Write($"num: {num}\n");
            }

        }

        public static void GreaterThanChoice(int[] numbers, int chosenNum, int countNum)
        {

            Console.Write($"Input the number of members on the List : {countNum} ");
            int a = Convert.ToInt32(Console.ReadLine());
            List<int> ints = new List<int>();

            foreach (var num in numbers)
            {

            }

            var greater = from x in numbers
                          where x > 80
                          select x;

            Console.WriteLine("The numbers greater than 80 are: ");
            foreach (var num in greater)
            {
                Console.Write($"num: {num}\n");
            }

        }

        public static string StringChallenge(string str)
        {

            char[] charArray = str.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (char.IsLetter(charArray[i]))
                {
                    if (charArray[i] == 'z')
                    {
                        charArray[i] = 'a';
                    }
                    else if (charArray[i] == 'Z')
                    {
                        charArray[i] = 'A';
                    }
                    else
                    {
                        charArray[i]++;
                    }
                }

            }
            for (int i = 0; i < charArray.Length; i++)
            {
                if ("aeiou".Contains(charArray[i]))
                {
                    charArray[i] = char.ToUpper(charArray[i]);
                }
            }

            string challengeToken = "if91vos405";
            string finalOutput = new string(charArray) + challengeToken;

            char[] finalCharArray = finalOutput.ToCharArray();
            for (int i = 2; i < finalCharArray.Length; i += 3)
            {
                finalCharArray[i] = 'X';
            }

            return new string(finalCharArray);
        }

    }
}
