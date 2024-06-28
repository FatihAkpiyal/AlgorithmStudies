using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUygulamasi.Basics
{
    public class CustomFunctions
    {

        public static bool EqualToTwenty(int a, int b)
        {
            a = Console.Read();
            b = Console.Read();

            if (a == 20 || b ==20 || a+b==20)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static void biggerLetter(string text)
        {

            string[] words = text.Split(new[]{" "}, StringSplitOptions.None);

            int counter = 0;
            string biggerLetter = "";

            foreach (string word in words)
            {
                if(word.Length > counter) 
                {
                    biggerLetter = word;
                    counter = word.Length;
                }
            }

           Console.WriteLine(biggerLetter);
        }

        public static void oddNum()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
                
            }
        }

        public static void PrimeNum()
        {
            int counter = 0;

            
            for (int i = 0; i < 501; i++)
            {
                int x = (int)Math.Floor(Math.Sqrt(i));

                if (x == 1) Console.WriteLine("false"); // 1 is not a prime number
                if (x == 2) Console.WriteLine("True");

                for (int j = 2; j <x; j++)
                {
                    if(x%j != 0)
                    {
                        counter = counter + x;
                    }
                }
              
            }
            Console.WriteLine(counter);
        }


        public static void IndextToGıvenNum(string text, int num)
        {


            if (text.Length >= 0)
            {
                Console.WriteLine(text.Substring(num, 2));
            }
            else
            {
                Console.WriteLine(text.Substring(0, 2));
            }
            
        }

        public static void CountSameLetter(string text)
        {

            int counter = 0;
            for(int i = 0; i < text.Length-1; i++)
            {
                if (text.Substring(i, 2)=="aa")
                {
                    counter++;
                }
                
            }
            Console.WriteLine(counter);
        }

        public static void JumpSecondLetter(string text)
        {
            var result = string.Empty; // Variable to store the resulting string

            // Loop through the characters of the input string
            for (var i = 0; i < text.Length; i++)
            {
                // Check if the current index 'i' is even
                if (i % 2 == 0)
                {
                    // Append the character at index 'i' to the result string
                    result += text[i];
                }
            }

            Console.WriteLine(result);
        }

        public static void CheckArrayForNum(int[] arr,int num)
        {
            bool check = false;

            //foreach (var item in arr)
            //{
            //    if (item.Equals(num))
            //    {
            //        check = true;
            //    }

            //}
            if(arr.Contains(num))
            {
                check = true;
            }
            Console.WriteLine(check);
        }

        public static void RemoveFirstAndLast(string text, string letter)
        {

            for (int i = text.Length - 2; i > 0; i--)
            {
                // Check if the current character is equal to the given character 'c'
                if (text[i] == letter[0])
                {
                    // If so, remove that character from the string 'str1'
                    text = text.Remove(i, 1);
                }
            }

            Console.WriteLine(text);
        }

        public static void FizzOrBuzz(string text)
        {
            text = char.ToUpper(text[0]) + text.Substring(1);

            if (text.StartsWith("F")  && text.EndsWith("b"))
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (text.StartsWith("B"))
            {
                Console.WriteLine("Buzz");
            }
            else if (text.StartsWith("F"))
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine(text);
            }
        }

        public static void FindLargestBySeven(int a,int b)
        {
            if (a%7==0 && b % 7 ==0)
            {
                int c = Math.Min(a,b);
                Console.WriteLine(c);
            }
            else if(a == b)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(Math.Max(a,b));
            }
        }

        public static void CheckNumsOneTwo(int[] arr)
        {
            
                if (arr[0] == arr[1])
                {
                    Console.WriteLine(arr[2]);
                }
                else
                {
                    Console.WriteLine(arr[0] + arr[1] + arr[2]);
                }
            
        }

        public static void DeleteFirstAndLast(string text)
        {
            text = text.Substring(1, text.Length - 2);

            Console.WriteLine(text);
        }

    }
}
