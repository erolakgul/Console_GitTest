﻿using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Console_GitTest.StringHelper
{
    public static class StringManipulation
    {

        // bir stringteki unique harf sayısı
        public static int LongestStringWithoutRepeatChar(string s)
        {
            int lenghtString = s.Length;
            char[] _CharArray = s.ToCharArray();
            char[] _CharArray2 = new Char[lenghtString];

            int count = 0;

            for (int i = 0; i < _CharArray.Length; i++)
            {

                if (!_CharArray2.Contains(_CharArray[i]))
                {
                    _CharArray2[count] = _CharArray[i];
                    count++;
                }
            }

            return count;
        }

        // tekrar etmeyen en uzun string
        // pwwkew => wke olarak alıp sonucu 3 dönmesi
        // bbbbbb => b olarak alıp sonucu 1 dönmesi
        // abcabcbb => abc olarak alıp sonucu 3 dönmesi
        public static int Without_Repeated_Chars_Longest_Substring(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;
            var map_str = new Dictionary<char, int>();

            var max_len = 0;
            var last_repeat_pos = -1;

            for (int i = 0; i < s.Length; i++)
            {
                char charFollow = s[i];

                if (map_str.ContainsKey(s[i]))
                {
                    int charOrderCount = map_str[s[i]];

                    if (last_repeat_pos < charOrderCount)
                    {

                        last_repeat_pos = charOrderCount;
                    }

                }

                if (max_len < i - last_repeat_pos)
                {
                    max_len = i - last_repeat_pos;
                }

                map_str[s[i]] = i;
            }

            return max_len;
        }

        //ör babad => bab
        public static string LongestPalindromSubstring(string str)
        {
            string longestPalindrome = "";
            int longestPalindromeLength = 0;

            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 1; j <= str.Length - i; j++)
                {
                    string currentWord = str.Substring(i, j);

                    bool isPalindrome = true;
                    for (int k = 0; k < currentWord.Length / 2; k++)
                    {
                        if (currentWord[k] != currentWord[currentWord.Length - 1 - k])
                        {
                            isPalindrome = false;
                            break;
                        }
                    }

                    if (isPalindrome && currentWord.Length > longestPalindromeLength)
                    {
                        longestPalindrome = currentWord;
                        longestPalindromeLength = currentWord.Length;
                    }
                }
            }

            return longestPalindrome;
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";

            StringBuilder stringBuilder = new();

            int shortestString = int.MaxValue;
            int shortestArrayString = int.MaxValue;

            for (int i = 0; i < strs.Length; i++)
            {
                if (shortestString > strs[i].Length)
                {
                    shortestString = strs[i].Length;
                    shortestArrayString = i;
                }
            }


            for (int i = 0; i < shortestString; i++)
            {
                stringBuilder.Append(strs[shortestArrayString].Substring(i, 1));

                bool isOk = true;

                for (int j = 0; j < strs.Length; j++)
                {
                    if (strs[j].Substring(0, stringBuilder.Length) != stringBuilder.ToString())
                    //if (!strs[j].Contains(stringBuilder.ToString()))
                    {
                        isOk = false;
                        break;
                    }
                }

                if (!isOk)
                {
                    stringBuilder.Remove(stringBuilder.ToString().Length - 1, 1);
                    break;
                }
            }

            return stringBuilder.ToString();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            // hastable içeriği şuan
            // [0,2] [1,5] [2,8]

            // örneğin target 13 geldi, int dizisi içinde dönerken şu şekilde tarama yapıp toplamalı
            //
            // [2,5,8] =>  2           || 5 
            //               5 => 7    ||  8 => 13 bingo bu durumda int dizisinde 1 ve 2.ci satırların toplamı 13 yaptığından new int[1,2] diye dönmeli
            //               8 => 10   ||
            //

            bool isOk = false;
            int[] _response = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j && !isOk)
                    {
                        if (nums[i] + nums[j] == target)
                        {
                            _response[0] = i;
                            _response[1] = j;
                            isOk = true;
                            break;
                        }
                    }
                }
            }

            return _response;
        }

        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            Hashtable hashtable = new();
            int counter = 0;

            for (int i = 0; i < nums1.Length; i++)
            {
                for (int j = 0; j < nums2.Length; j++)
                {
                    if (nums1[i] == nums2[j])
                    {
                        if (!hashtable.ContainsValue(nums1[i]))
                        {
                            hashtable.Add(counter, nums1[i]);
                            counter++;
                        }
                    }
                }
            }

            int[] _response = new int[hashtable.Count];
            foreach (DictionaryEntry item in hashtable)
            {
                _response[Convert.ToInt32(item.Key)] = Convert.ToInt32(item.Value);
            }

            return _response;
        }

        public static string IntToRoman(int num)
        {
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            keyValuePairs.Add(1, "I");
            keyValuePairs.Add(4, "IV");
            keyValuePairs.Add(5, "V");
            keyValuePairs.Add(9, "IX");
            keyValuePairs.Add(10, "X");
            keyValuePairs.Add(40, "XL");
            keyValuePairs.Add(50, "L");
            keyValuePairs.Add(90, "XC");
            keyValuePairs.Add(100, "C");
            keyValuePairs.Add(400, "CD");
            keyValuePairs.Add(500, "D");
            keyValuePairs.Add(900, "CM");
            keyValuePairs.Add(1000, "M");


            StringBuilder stringBuilder = new();

            // 1994
            int lengtNum = num.ToString().Length;
            int maxUnit = 1;

            for (int i = 1; i < lengtNum + 1; i++)
            {
                if (i != 1)
                {
                    maxUnit = maxUnit * 10;
                }
            }

            for (int i = lengtNum; i >= 0; i--)
            {
                if (maxUnit != 0)
                {
                    int factor = 0;
                    factor = num / (maxUnit);

                    if (keyValuePairs.ContainsKey(factor * maxUnit))
                    {
                        stringBuilder.Append(keyValuePairs.Where(c => c.Key == factor * maxUnit).Select(f => f.Value).SingleOrDefault());
                    }
                    else
                    {
                        int upNum = maxUnit * 10;
                        int diffNum = upNum - (factor * maxUnit);

                        string _currentRoman = "";
                        _currentRoman = keyValuePairs.Where(c => c.Key == diffNum).Select(f => f.Value).SingleOrDefault() + keyValuePairs.Where(c => c.Key == upNum).Select(f => f.Value).SingleOrDefault();
                        stringBuilder.Append(_currentRoman);
                    }

                    maxUnit = maxUnit / 10;

                    if (num.ToString().Length != 1)
                    {
                        num = Convert.ToInt32(num.ToString().Remove(0, 1));
                    }
                }

            }


            return stringBuilder.ToString();
        }


    }
}
