using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Exercises1
{
    public static class HashTableEx
    {
        public static void FirstReccuringCharacter(string str)
        {
            var chars = new Dictionary<char, int>();
            foreach (var item in str)
            {
                if (chars.ContainsKey(item) == false)
                {
                    chars.Add(item, 1);
                }
                else if (chars.ContainsKey(item) == true)
                {
                    Console.WriteLine(item);
                    break;
                }
            }
        }

        public static void FirstRecCharLoop(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i-1; j >= 0; j++)
                {
                    if (str[i] == str[j])
                    {
                        Console.WriteLine(str[i]);
                        return;
                    }
                }
            }
        }
    }
}
