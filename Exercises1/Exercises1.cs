using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises1
{
    public class Exercises1
    {

        public static void FindSumBubbleSorted(int[] arr, int sum)
        {
            // loop through the array pairs
            // if the pair gives sum, print yes and close the function
            var length = arr.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++) // this way will not use the item at the same index
                {
                    var itemSum = arr[i] + arr[j];
                    if (itemSum == sum)
                    {
                        Console.WriteLine("Yes");
                        return;
                    }
                }
            }
            Console.WriteLine("No");
        }

        public static void FindSumUnsorted(int[] array, int sum)
        {
            HashSet<int> comp = new HashSet<int>();
            foreach (var item in array)
            {
                if (comp.Contains(item))
                {
                    Console.WriteLine("Found");
                    return;
                }
                comp.Add(sum - item);
            }
            Console.WriteLine("Not Found");
            return;
        }

        public static void FindSumLinearSorted(int[] arr, int sum)
        {
            var length = arr.Length - 1;
            var i = 0;
            while (i < length)
            {
                if (arr[i] + arr[length] < sum)
                {
                    i++;
                }
                else if (arr[i] + arr[length] > sum)
                {
                    length--;
                }
                else if (arr[i] + arr[length] == sum)
                {
                    Console.WriteLine("Found");
                    return;
                }
            }
            Console.WriteLine("Not Found");
        }

        public static void LinqTwo()
        {
            int[] arr = { 1, 2, 3, 4, 5, -6, -7, -8, -9, 11, 12, 15 };

            var linqVar =
                from num in arr
                where num > 0
                where num < 12
                select num;

            foreach (var item in linqVar)
            {
                Console.WriteLine(item);
            }
        }

        public static void LinqOne()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var nQuery =
                from num in arr
                where (num % 2) == 0
                select num;

            foreach (var item in nQuery)
            {
                Console.WriteLine(item);
            }
        }

        public static void SecondLargest()
        {
            int[] arr = { 1, 6, 3, 4, 5 };

            int max1 = arr[0];
            int max2 = arr[1];

            foreach (var item in arr)
            {
                if (item > max1)
                {
                    max2 = max1;
                    max1 = item;
                }
                else if (item >= max2 && item != max1)
                {
                    max2 = item;
                }
            }
            Console.WriteLine(max2);
        }

        public static void SumOfDIgits(int num)
        {
            var strNum = num.ToString();
            var sum1 = 0;
            var sum2 = 0;
            var sum3 = 0;
            while (num > 0)
            {
                sum3 += num % 10;
                num /= 10;
            }
            foreach (var item in strNum)
            {
                sum1 += Int32.Parse(item.ToString());
                sum2 += Convert.ToInt32(item.ToString());
            }
            Console.WriteLine(sum1);
            Console.WriteLine(sum2);
            Console.WriteLine(sum3);
        }

        public static void IsPrime(int num)
        {
            var dividers = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    dividers++;
                }
            }
            if (dividers < 3)
            {
                Console.WriteLine($"Prime - {num}");
            }
        }

        public static void RightRotationArray()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int size = array.Length - 1;
            int temp = array[size];
            for (int i = size; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = temp;

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static void LeftRotationArray()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int size = array.Length - 1;
            int temp = array[0];
            for (int i = 0; i < size; i++)
            {
                array[i] = array[i + 1];
            }
            array[size - 1] = temp;

            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }

        public static void AllPossibleSubstrings(string str)
        {
            string substrings = "";
            for (int i = 0; i < str.Length; i++)
            {
                substrings += $"{str.Substring(i, str.Length - i)} ";
            }
            Console.WriteLine(substrings);
        }

        public static void OccurenceInAString(string str)
        {
            Dictionary<char, int> characters = new Dictionary<char, int>();
            foreach (var character in str)
            {
                if (character != ' ')
                {
                    if (characters.ContainsKey(character))
                    {
                        characters[character]++;
                    }
                    else
                    {
                        characters.Add(character, 1);
                    }
                }
            }
        }

        public static void ReverseWords()
        {
            string sentence = "Welcome to test function";
            var reverseSent = "";
            var subs = "";
            var spaceIndex = sentence.Length;
            Console.WriteLine(spaceIndex);
            for (int i = sentence.Length - 1; i >= 0; i--)
            {
                if (sentence[i] == ' ')
                {
                    Console.WriteLine(i);
                    subs = sentence.Substring(i, spaceIndex - i);
                    reverseSent += $"{subs} ";
                    spaceIndex = i;
                }
            }
            Console.WriteLine(reverseSent);
        }

        public static void ReverseString()
        {
            var str = "hello";
            var reverseStr = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                var character = str[i];
                var substr = character.ToString();
                reverseStr += substr;
            }
            Console.WriteLine(reverseStr);

        }

        public static void BubbleSort()
        {
            int[] arr = { 78, 55, 45, 98, 13 };
            int temp;
            for (int j = 0; j < arr.Length - 1; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
        }

        public static void IsRotation()
        {
            int[] array1 = new int[7] { 1, 2, 3, 4, 5, 6, 7 };
            int[] array2 = new int[7] { 4, 5, 6, 7, 1, 2, 3 };

            int i1 = 0;
            int indexDiff = 0;
            int rotation = 0;

            if (array1.Length != array2.Length)
            {
                Console.WriteLine("Nope");
            }

            if (array2.Contains(array1[i1]))
            {
                for (int i = 0; i < array2.Length; i++)
                {
                    if (array2[i] == array1[i1])
                    {
                        indexDiff = i - i1;
                        break;
                    }
                }
            }
            var i2 = i1 + indexDiff;
            var i3 = i1 - indexDiff + 1;
            for (int i = 0; i < array1.Length; i++)
            {
                if (i2 < array2.Length)
                {
                    if (array1[i] != array2[i2])
                    {
                        Console.WriteLine("Not a rotation");
                        rotation++;
                        break;
                    }
                }
                else
                {
                    if (array1[i] != array2[i3])
                    {
                        Console.WriteLine("Not a rotation");
                        rotation++;
                        break;
                    }
                }
                i2++;
                i3++;
            }
            if (rotation == 0)
            {
                Console.WriteLine("Rotation");
            }
        }

        public static void CommonElementsTwo()
        {
            int[] array1 = new int[6] { 1, 3, 4, 6, 7, 9 };
            int[] array2 = new int[6] { 1, 2, 4, 5, 9, 10 };

            var i1 = 0;
            var i2 = 0;
            var result = new List<int>();

            while (i1 < array1.Length && i2 < array2.Length)
            {
                var e1 = array1[i1];
                var e2 = array2[i2];

                if (e1 == e2)
                {
                    result.Add(e1);
                    i1++;
                    i2++;
                }
                else if (e1 > e2)
                {
                    i2++;
                }
                else
                {
                    i1++;
                }
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        public static void CommonElements()
        {
            int[] array1 = new int[6] { 1, 3, 4, 6, 7, 9 };
            int[] array2 = new int[6] { 1, 2, 4, 5, 9, 10 };

            List<int> commonElements = new List<int>();

            foreach (var item1 in array1)
            {
                foreach (var item2 in array2)
                {
                    if (item1 == item2)
                    {
                        commonElements.Add(item1);
                    }
                }
            }
            foreach (var item in commonElements)
            {
                Console.WriteLine(item);
            }
        }

        public static void MostFrequent()
        {
            int[] array = new int[6] { 1, 3, 1, 3, 2, 1 };

            int mostFreq = -1;
            int freq = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int currFreq = 0;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        currFreq++;
                    }
                }
                if (currFreq > freq)
                {
                    mostFreq = array[i];
                    freq = currFreq;
                }
            }
            Console.WriteLine(mostFreq);
        }

        public static string MakesTwenty()
        {
            int[] array = new int[5] { 3, 4, 5, 2, 6 };
            for (int i = 0; i < array.Length; i++)
            {
                var num1 = array[i];
                for (int j = 0; j < array.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    var multi = array[i] * array[j];
                    if (multi == 20)
                    {
                        return $"{array[i]} - {array[j]}";
                    }
                }
            }
            return "None";
        }

        public static void ConcurringCharacter(string str)
        {
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == str[i + 1])
                {
                    Console.WriteLine(str[i]);
                }
            }
        }

        public static void RecurringCharacter(string str)
        {
            List<char> characters = new List<char>();
            foreach (var item in str)
            {
                if (characters.Contains(item))
                {
                    Console.WriteLine(item);
                    break;
                }
                characters.Add(item);
            }
        }

        public static void ArmstrongNumber(int num)
        {
            string strNum = num.ToString();
            int sum = 0;
            int length = strNum.Length;
            for (int i = 0; i < length; i++)
            {
                int dig = Int32.Parse(strNum[i].ToString());
                //Console.WriteLine(dig);
                var power = Math.Pow(dig, length);
                //Console.WriteLine(digPower);
                sum += Convert.ToInt32(power);
            }
            if (num == sum)
            {
                Console.WriteLine($"{num} - {sum}");
                Console.WriteLine("Armstrong");
            }
            //else
            //{
            //    Console.WriteLine($"{num} - {sum}");
            //    Console.WriteLine("Not Armstrong");
            //}
        }

        public static void PrimeNumbers()
        {
            List<int> primeNums = new List<int>();
            for (int i = 2; i <= 100; i++)
            {
                var divs = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        divs++;
                    }
                }
                if (divs <= 2)
                {
                    primeNums.Add(i);
                }

            }
            foreach (var item in primeNums)
            {
                Console.WriteLine(item);
            }
        }

        public static void Palindrome(int a)
        {
            var stringNum = a.ToString();
            var length = stringNum.Length;
            for (int i = 0; i < (length - 1); i++)
            {
                var firstNum = stringNum[i];
                var lastNum = stringNum[length - 1 - i];
                if (firstNum != lastNum)
                {
                    Console.WriteLine($"{firstNum} - {lastNum}");
                    Console.WriteLine($"{a} - Not a palindrome");
                    break;
                }
                if (i == length - i - 1 || i == length / 2)
                {
                    Console.WriteLine($"{a} - palindrome");
                    break;
                }
            }
        }
        public static void FizzBuzz2()
        {
            string output;
            for (int i = 1; i <= 100; i++)
            {
                output = "";
                if (i % 3 == 0) output += "Fizz";
                if (i % 5 == 0) output += "Buzz";
                if (output == "") output += i.ToString();
                Console.WriteLine(output);
            }
        }

        public static void FizzBuzz()
        {
            const int fizz = 3;
            const int buzz = 5;
            List<string> fizzBuzz = new List<string>();
            for (int i = 1; i < 101; i++)
            {
                if (i % fizz == 0 && i % buzz == 0)
                {
                    fizzBuzz.Add("FizzBuzz");
                }
                else if (i % fizz == 0)
                {
                    fizzBuzz.Add("Fizz");
                }
                else if (i % buzz == 0)
                {
                    fizzBuzz.Add("Buzz");
                }
                else
                {
                    fizzBuzz.Add($"{i}");
                }
            }
            foreach (var item in fizzBuzz)
            {
                Console.WriteLine(item);
            }
        }

        public static bool MultipleOfThreeOrSeven(int a)
        {
            const int b = 3;
            const int c = 7;

            return a % b == 0 || a % c == 0;
        }

        public static string LastAdded(string str)
        {
            char lastChar = str[str.Length - 1];
            return $"{lastChar}{str}{lastChar}";
        }

        public static string FourTimesStart(string str)
        {
            if (str.Length < 2)
            {
                return str;
            }
            else
            {
                var sub = str.Substring(0, 2);
                return $"{sub}{sub}{sub}{sub}";
            }
        }

        public static string SwapFirstAndLast(string str)
        {
            var firstLetter = str[0];
            var lastLetter = str[str.Length - 1];
            var rest = str.Substring(1, str.Length - 2);
            string newString = $"{lastLetter}{rest}{firstLetter}";
            return newString;
        }

        public static string RemoveCharacterAtPosition(string str, int pos)
        {
            if (pos > str.Length)
            {
                return "Invalid Index";
            }
            else
            {
                return str.Remove(pos, 1);
            }
        }

        public static string AddIfToStart(string str)
        {
            string strStart = str.Substring(0, 2);
            if (strStart.ToLower() == "if")
            {
                return str;
            }
            else
            {
                return $"if {str}";
            }
        }

        public static bool IfWIthinTen(int a)
        {
            const int interval = 10;
            const int b = 100;
            const int c = 200;

            int diffAB = Math.Abs(a - b);
            int diffAC = Math.Abs(a - c);

            return diffAB <= interval || diffAC <= interval;

        }

        public static bool TrueIfThirty(int a, int b)
        {
            const int c = 30;
            return a == c || b == c || (a + b) == c;
        }

        public static int TripleSumIfSame(int a, int b)
        {
            int c;
            if (a == b)
            {
                c = (a + b) * 3;
            }
            else
            {
                c = a + b;
            }
            return c;
        }

        public static int TripleIfBigger(int a)
        {
            const int x = 51;
            int b = Math.Abs(x - a);
            if (a > x)
            {
                return b * 3;
            }
            else
            {
                return b;
            }
        }

    }
}
