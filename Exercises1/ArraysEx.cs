using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1
{
    public class ArraysEx
    {

        public static void LongestWord(string str)
        {
            // take the string and split it using any aspecial characters
            // take the length of the words
            // return the longest one
            HashSet<int> nonletters = new HashSet<int>();
            var index = 0;
            foreach (var character in str)
            {
                if (!char.IsLetter(character))
                {
                    nonletters.Add(index);
                }
                index++;
            }
            int start_index = 0;
            int end_index = 0;
            int max_word_length = 0;
            int max_word_index = 0;
            int last_index = 0;
            foreach (var item in nonletters)
            {
                last_index = item;
                start_index = end_index;
                end_index = item;
                if (end_index == start_index)
                {
                    continue;
                }
                if ((end_index - start_index) > max_word_length)
                {
                    max_word_length = (end_index - start_index);
                    max_word_index = start_index;
                }
                Console.WriteLine($"{start_index} - {end_index}");
            }
            if (str.Length - last_index > max_word_length)
            {
                Console.WriteLine(str.Substring(last_index));
            }
            else
            {
                Console.WriteLine(str.Substring(max_word_index+1, max_word_length-1));
            }
        }

        public static bool ContainsDupes(int[] arr)
        {
            HashSet<int> set = new HashSet<int>();
            foreach (var item in arr)
            {
                if (set.Contains(item) == false)
                {
                    set.Add(item);
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        public static void MoveZeroes(int[] arr)
        {
            // move all zeroes to the end of the array
            // count all the non-zero elements
            // reassign the array for the non-zeroes
            // add the difference between length and count as zeroes
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[counter] = arr[i];
                    counter++;
                }

            }
            while(counter < arr.Length)
            {
                arr[counter] = 0;
                counter++;
            }
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
        }

        public static void MaximumSubarraySum(int[] arr)
        {
            var len = arr.Length;
            var max = 0;
            int current_max = 0;

            for (int i = 0; i < len; i++)
            {
                current_max = current_max + arr[i];
                if (current_max < 0)
                {
                    current_max = 0;
                }
                if (current_max > max)
                {
                    max = current_max;
                }
            }

            Console.WriteLine(max);
        }

        public static bool TwoArraysSumTarget(int[] arr1, int[]arr2, int sum)
        {
            int i = 0;
            int j = arr2.Length - 1;
            while (i < arr1.Length && j > 0)
            {
                Console.WriteLine($"i:{i} j:{j}");
                if (arr1[i] + arr2[j] == sum)
                {
                    Console.WriteLine(arr1[i]);
                    return true;
                }
                if (arr1[i] + arr2[j] < sum)
                {
                    i++;
                }
                else if (arr1[i] + arr2[j] > sum)
                {
                    j--;
                }
            }
            return false;
        }

        // reverse a string
        // Well hello there Mr. UPS man!
        public static void ReverseString(string str)
        {
            List<string> newStr = new List<string>();
            for (int i = str.Length-1; i >= 0; i--)
            {
                newStr.Add(str[i].ToString());
            }
            newStr.ToString();
            foreach (var item in newStr)
            {
                Console.Write(item);
            }
        }

        // merge sorted arrays
        // [1, 3, 7, 9, 16, 35, 48]
        // [2, 6, 12, 24, 68, 76]
        public static void MergeSortedArrays(int[] arr1, int[] arr2)
        {
            var len1 = arr1.Length;
            var len2 = arr2.Length;
            var i1 = 0;
            var i2 = 0;
            List<int> newArr = new List<int>();
            while (i1 < len1 && i2 < len2)
            {
                var num1 = arr1[i1];
                var num2 = arr2[i2];
                if (arr1[i1] == arr2[i2])
                {
                    newArr.Add(arr1[i1]);
                    i1++;
                    i2++;
                }
                else if (arr1[i1] < arr2[i2])
                {
                    newArr.Add(arr1[i1]);
                    i1++;
                }
                else if (arr2[i2] < arr1[i1])
                {
                    newArr.Add(arr2[i2]);
                    i2++;
                }
            }
            while (i1 < len1)
            {
                newArr.Add(arr1[i1]);
                i1++;
            }
            while (i2 < len2)
            {
                newArr.Add(arr2[i2]);
                i2++;
            }
            foreach (var item in newArr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
