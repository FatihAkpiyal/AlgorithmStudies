using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleUygulamasi.AlgorithmExamples
{
    public class InterViewSolutions
    {

        public static string ArrayChallenge(int[] arr)
        {
            // En büyük sayıyı bul
            int max = arr.Max();

            // En büyük sayıyı çıkararak yeni bir dizi oluştur
            int[] newArr = arr.Where(x => x != max).ToArray();

            // Kombinasyonları kontrol et
            bool result = CheckCombination(newArr, max, 0, 0);

            // Sonucu string olarak döndür
            return result ? "true" : "false";
        }

        public static bool CheckCombination(int[] arr, int target, int index, int currentSum)
        {
            // Eğer mevcut toplam hedefe eşitse true döndür
            if (currentSum == target)
            {
                return true;
            }

            // Dizinin sonuna geldiysen ve hedefe ulaşmadıysan false döndür
            if (index >= arr.Length)
            {
                return false;
            }

            // Mevcut elemanı ekleyerek ve eklemeden kombinasyonları kontrol et
            return CheckCombination(arr, target, index + 1, currentSum + arr[index]) || CheckCombination(arr, target, index + 1, currentSum);
        }

       
    }
}
