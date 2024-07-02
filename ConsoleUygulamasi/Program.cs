using ConsoleUygulamasi.AlgorithmExamples;
using ConsoleUygulamasi.Basics;
using System;
using System.Text.RegularExpressions;

namespace AlgorithmExperiements
{
    public class Program
    {
        static void Main(string[] args)
        {

            //MultiplierTable.calculator();

            //num4Calculate.CalculateFourNum();

            //Splitter.Splittter();

            //letterChanger.LetterChanger("Fatih");

            //NegativePositiveCheck.NegPosChecker();

            //CustomFunctions.EqualToTwenty(10,12);

            //CustomFunctions.biggerLetter("buradaki en büyük kelime amerikabirleşikdevletleridir! ");

            //CustomFunctions.oddNum();

            //CustomFunctions.PrimeNum();

            //CustomFunctions.IndextToGıvenNum("Fatih", 2);

            ////CustomFunctions.CountSameLetter("faatih aaakpiyaal");

            //CustomFunctions.CountSameLetter("faatih");

            //CustomFunctions.JumpSecondLetter("Faatih");

            //CustomFunctions.CheckArrayForNum([1,2,3,4],2);

            //CustomFunctions.RemoveFirstAndLast("xxfatihxx","x");

            //CustomFunctions.FizzOrBuzz("fatih");
            //CustomFunctions.FizzOrBuzz("barista");
            //CustomFunctions.FizzOrBuzz("fatihb");
            //CustomFunctions.FizzOrBuzz("hebele");

            //CustomFunctions.FindLargestBySeven(21,11);
            //CustomFunctions.FindLargestBySeven(20,10);
            //CustomFunctions.FindLargestBySeven(10,10);

            //CustomFunctions.CheckNumsOneTwo([1,2,3]);
            //CustomFunctions.CheckNumsOneTwo([2, 2, 3]);
            //CustomFunctions.CheckNumsOneTwo([1, 2, 3]);

            //CustomFunctions.DeleteFirstAndLast("fatihfatih");


            /*---------------------------------------------------------------------------------------*/


            //ForLoops.TriangleNums();

            //ForLoops.TriangleNumsSort();

            //ForLoops.TriangleIncrease();

            /*---------------------------------------------------------------------------------------*/

            //StringProblems.StringLength("fatih");

            //StringProblems.StringReverser("fatih");

            //StringProblems.WordCounter("Beni işe alır mısınız dostum?");


            //LINQExamples.BeginEndWithLinq(new string[] { "Aydın", "izmir", "istanbul","ibir" }, "i", "r");

            //LINQExamples.GreaterThanEightee(new int[] { 15, 25, 42, 52, 90, 89, 82, 81 });

            //Console.WriteLine(LINQExamples.StringChallenge(Console.ReadLine()));


            string input = Console.ReadLine();
            
            var match = Regex.Match(input, @"new int\[] \{(.+?)\}");
            if (match.Success)
            {
                int[] inputArr = match.Groups[1].Value.Split(',').Select(int.Parse).ToArray();
                // Sonucu yazdır
                Console.WriteLine(InterViewSolutions.ArrayChallenge(inputArr));
            }
            else
            {
                Console.WriteLine("Invalid input format.");
            }
        }
    }

    
}

