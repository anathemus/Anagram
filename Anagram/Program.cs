using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    public class Program
    {
        static void Main(string[] args)
        {
            string inputStr1 = Console.ReadLine();
            string inputStr2 = Console.ReadLine();

            if (IsAnagram(inputStr1, inputStr2))
            {
                Console.WriteLine("It is an anagram!");
            }
            else
            {
                Console.WriteLine("It is not an anagram.");
            }
            Console.ReadLine();
        }

        public static bool IsAnagram(string str1, string str2)
        {
            bool isAnagram = true;

            if (str1.Length == str2.Length)
            {
                str1 = str1.ToLower();
                char[] cArray1 = ToOrderedCharArray(str1);

                str2 = str2.ToLower();
                char[] cArray2 = ToOrderedCharArray(str2);

                if (cArray1.ToString() != cArray2.ToString())
                {
                    isAnagram = false;
                }
            }
            else
            {
                isAnagram = false;
            }

            return isAnagram;
        }

        public static char[] ToOrderedCharArray(string str)
        {
            char[] cArray = str.ToArray();
            char temp;
            int j;

            for(int i = 1; i < cArray.Length; i++)
            {
                temp = cArray[i];
                j = i - 1;
                while (j >= 0 && cArray[j] > temp)
                {
                    cArray[j + 1] = cArray[j];
                    j--;
                }
                cArray[j + 1] = temp;
            }
            return cArray.Where(c => !char.IsPunctuation(c)).ToArray();
        }
    }
}
