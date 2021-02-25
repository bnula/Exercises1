using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1
{
    public class Exercises2
    {
        // given 2 arrays, find if they have any common items
        // 1, 2, 3, 4, 5
        // 5, 6, 7, 8, 9
        // 7, 8, 9, 10, 11
        // 1, 5, 9, 13, 22
        // 4, 6, 8, 22, 34

        public static void Fibonacci(int n)
        {
            var num1 = 1;
            var num2 = 0;
            int temp;
            for (int i = 0; i < n; i++)
            {
                temp = num2;
                Console.WriteLine(num1 + num2);
                num2 = num1 + temp;
                num1 = temp;
            }
        }

        public static void CommonItems(int[] arr1, int[] arr2)
        {
            var i1 = 0;
            var i2 = 0;
            while (i2 < arr2.Length && i1 < arr1.Length)
            {
                if (arr1[i1] == arr2[i2])
                {
                    Console.WriteLine("Common Item");
                    return;
                }
                if (arr1[i1] < arr2[i2])
                {
                    i1++;
                }
                if (arr2[i2] < arr1[i1])
                {
                    i2++;
                }
            }
            Console.WriteLine("Not Found");
            return;
        }

        public static void CommonItems(string[] arr1, string[] arr2)
        {
            HashSet<string> set1 = new HashSet<string>();
            HashSet<string> commonItems = new HashSet<string>();

            foreach (var item in arr1)
            {
                if (!set1.Contains(item))
                {
                    set1.Add(item);
                }
            }

            foreach (var item in arr2)
            {
                if (set1.Contains(item) && !commonItems.Contains(item))
                {
                    commonItems.Add(item);
                }
            }

            Console.Write($"Common Items: ");
            foreach (var item in commonItems)
            {
                Console.Write($"{item}, ");
            }
        }
    }
}
