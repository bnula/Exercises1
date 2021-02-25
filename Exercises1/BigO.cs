using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises1
{
    class BigO
    {
        public static void FindNemo(string[] arr)
        {
            // O(n) --> Linear Time
            foreach (var item in arr)
            {
                if (item.ToLower() == "nemo")
                {
                    Console.WriteLine("Found Nemo!");
                }
            }
        }

        public static void CheckFirst(object[] arr)
        {
            // O(1) --> Constant Time
            if(arr[0].ToString() == "nemo")
            {
                Console.WriteLine("Nemo was First");
            }
        }

        public static void LogAllPairs(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.Write(arr[i]);
                    Console.WriteLine(arr[j]);
                }
            }
        }

    }
}
