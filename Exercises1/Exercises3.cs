using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises1
{
    public static class Exercises3
    {

        public static string ReverseStringRecursive(string str, string ch = "", string revStr = "")
        {
            revStr += ch.ToString();
            if (str.Length == 0)
            {
                Console.WriteLine(revStr);
                return revStr;
            }
            return ReverseStringRecursive(str.Substring(0, str.Length - 1), str[str.Length-1].ToString(), revStr);
        }

        public static int FibonacciRecursive(int f1, int f2, int counter, int num)
        {
            Console.WriteLine(f1);
            if (counter == num)
            {
                return f1 + f2;
            }

            return FibonacciRecursive(f2, f1 + f2, counter + 1, num);
        }

        public static void FibonacciIterative(int num)
        {
            int f1 = 0;
            int f2 = 1;
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            for (int i = 1; i <= num; i++)
            {
                int sum = f1 + f2;
                Console.WriteLine(sum);
                f1 = f2;
                f2 = sum;
            }
        }

        public static int FactorialRecursive(int num)
        {
            if (num == 2)
            {
                return 2;
            }
            return num * FactorialRecursive(num - 1);
        }

        public static void FactorialIterative(int num)
        {
            int fact = num;
            for (int i = num; i > 2; i--)
            {
                fact = fact * (i - 1);
            }
            Console.WriteLine(fact);
        }

        public static void PrintAsSpiralMatrix(int[,] arr)
        {
            int rowStart = 0;
            int colStart = 0;
            int rowEnd = arr.GetLength(0) - 1;
            int colEnd = arr.GetLength(1) - 1;
            var spiral = new List<int>();
            while (rowStart <= rowEnd && colStart <= colEnd)
            {
                for (int i = colStart; i <= colEnd; i++)
                {
                    spiral.Add(arr[rowStart, i]);
                }

                rowStart++;

                for (int i = rowStart; i <= rowEnd; i++)
                {
                    spiral.Add(arr[i, colEnd]);
                }

                colEnd--;

                if (rowStart <= rowEnd)
                {
                    for (int i = colEnd; i >= colStart; i--)
                    {
                        spiral.Add(arr[rowEnd, i]);
                    }
                }

                rowEnd--;

                if (colStart <= colEnd)
                {
                    for (int i = rowEnd; i >= rowStart; i--)
                    {
                        spiral.Add(arr[i, colStart]);
                    }
                }

                colStart++;
            }
            foreach (var item in spiral)
            {
                Console.WriteLine(item);
            }
        }

        public static void GenerateSpiralMatrix(int n)
        {
            var colEnd = n - 1;
            var colStart = 0;
            var rowEnd = n - 1;
            var rowStart = 0;
            int[,] arr = new int[n, n];
            var counter = 1;

            while (colStart <= colEnd && rowStart <= rowEnd)
            {

                for (int i = colStart; i <= colEnd; i++)
                {
                    arr[rowStart, i] = counter;
                    counter++;
                }
                rowStart++;

                for (int i = rowStart; i <= rowEnd; i++)
                {
                    arr[i, colEnd] = counter;
                    counter++;
                }
                colEnd--;

                if (colEnd >= colStart)
                {
                    for (int i = colEnd; i >= colStart; i--)
                    {
                        arr[rowEnd, i] = counter;
                        counter++;
                    }
                }
                rowEnd--;

                if (rowEnd >= rowStart)
                {
                    for (int i = rowEnd; i >= rowStart; i--)
                    {
                        arr[i, colStart] = counter;
                        counter++;
                    }
                }

                colStart++;
            }
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public static void VowelsInString(string str)
        {
            HashSet<char> vowels = new HashSet<char>();
            vowels.Add('a');
            vowels.Add('e');
            vowels.Add('i');
            vowels.Add('o');
            vowels.Add('u');
            vowels.Add('y');
            int vowelCnt = 0;
            foreach (var item in str.ToLower())
            {
                if (vowels.Contains(item))
                {
                    vowelCnt++;
                }
            }
            Console.WriteLine(vowelCnt);
        }

        public static void Pyramid(int n)
        {
            string str = "";
            for (int i = 0; i < n * 2 - 1; i++)
            {
                str += "_";
            }
            var strArray = str.ToArray();
            for (int i = 0; i < n; i++)
            {
                strArray[n - 1 + i] = '#';
                strArray[n - 1 - i] = '#';
                str = string.Join("", strArray);
                Console.WriteLine(str);
            }
        }

        public static void ShowSteps(int n)
        {
            string[] steps = new string[n];
            for (int i = 0; i < n; i++)
            {
                steps[i] = "#";
                foreach (var item in steps)
                {
                    Console.WriteLine($"|{item}|");
                }
            }
        }

        public static void Capitalize(string str)
        {
            var newStr = "";
            var i = 0;
            var capitalize = true;
            while (i < str.Length)
            {
                if (capitalize == true)
                {
                    newStr += str[i].ToString().ToUpper();
                    capitalize = false;
                }
                else
                {
                    newStr += str[i].ToString();
                }
                if (char.IsLetter(str[i]) == false)
                {
                    capitalize = true;
                }
                i++;
            }
            Console.WriteLine(newStr);
        }

        public static void Anagrams(string str1, string str2)
        {
            var letters1 = new Dictionary<char, int>();
            var letters2 = new Dictionary<char, int>();
            if (str1.Length != str2.Length)
            {
                Console.WriteLine("Not an anagram");
                return;
            }
            foreach (var item in str1)
            {
                if (char.IsLetter(item) == true)
                {
                    if (letters1.ContainsKey(item) == false)
                    {
                        letters1.Add(item, 1);
                    }
                    else
                    {
                        letters1[item]++;
                    }
                }
            }
            foreach (var item in str2)
            {
                if (char.IsLetter(item) == true)
                {
                    if (letters2.ContainsKey(item) == false)
                    {
                        letters2.Add(item, 1);
                    }
                    else
                    {
                        letters2[item]++;
                    }
                }

            }
            var items1 = letters1.OrderByDescending(i => i.Value);
            var items2 = letters2.OrderByDescending(i => i.Value);
            for (int i = 0; i < items1.Count(); i++)
            {
                var l1 = items1.ElementAt(i);
                var l2 = items2.ElementAt(i);
                Console.WriteLine($"{l1.Key} - {l2.Key}");
                Console.WriteLine($"{l1.Value} - {l2.Value}");
                if (l1.Equals(l2) == false)
                {
                    Console.WriteLine("Not an anagram");
                    return;
                }
            }
            Console.WriteLine("Anagram");
        }

        public static void ArrayChunks(int[] arr, int chunkSize)
        {
            var arrSize = arr.Length;
            List<int[]> newArr = new List<int[]>();
            List<int> tempArr = new List<int>();
            int iTemp = 0;
            for (int i = 0; i < arrSize; i++)
            {
                tempArr.Add(arr[i]);
                iTemp++;
                if (iTemp == chunkSize)
                {
                    newArr.Add(tempArr.ToArray());
                    tempArr = new List<int>();
                    iTemp = 0;
                }
            }
            if (tempArr.Count > 0)
            {
                newArr.Add(tempArr.ToArray());
            }
            foreach (var pair in newArr)
            {
                foreach (var item in pair)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("=====");
            }
        }

        public static void FizzBuzz(int n)
        {
            for (int i = 0; i < n; i++)
            {
                string str = "";
                if (i % 3 == 0)
                {
                    str += "Fizz";
                }
                if (i % 5 == 0)
                {
                    str += "Buzz";
                }
                if (str == "")
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(str);
                }
            }
        }

        public static void MostCommon(string str)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (var character in str)
            {
                if (dict.ContainsKey(character) == false)
                {
                    dict.Add(character, 1);
                }
                else if (dict.ContainsKey(character))
                {
                    dict[character]++;
                }
            }
            var items =
                from pair in dict
                orderby pair.Value descending
                select pair;

            foreach (var item in dict.OrderByDescending(i => i.Value))
            {
                Console.WriteLine(item);
                break;
            }

            foreach (var item in items)
            {
                Console.WriteLine(item);
                break;
            }
        }

        public static void ReverseString(string str)
        {
            string reverseString = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverseString += str[i];
            }
            Console.WriteLine(reverseString);
        }
    }
}
