using System;
using System.Collections.Generic;

namespace LongestSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string s = "abcabcbb";                                                                                                                                                                                                                                                                                                                                                 
            int a_pointer = 0;
            int b_pointer = 0;
            int max = 0;
            HashSet<char> hash = new HashSet<char>();
            while (b_pointer < s.Length)
            {
                if (!hash.Contains(s[b_pointer]))
                {
                    hash.Add(s[b_pointer]);
                    b_pointer++;
                    max = Math.Max(hash.Count, max);

                }
                else
                {
                    hash.Remove(s[a_pointer]);
                    a_pointer++;
                }
            }
            string r = "";
            foreach (char c in hash)
            {
                r += c.ToString();
            }
            Console.WriteLine(r);
            Console.ReadLine();
            //string s = "pwwkew";
            //int n = s.Length;
            //HashSet<char> set = new HashSet<char>();
            //int ans = 0, i = 0, j = 0;
            //while (i < n && j < n)
            //{
            //    // try to extend the range [i, j]
            //    if (!set.Contains(s[j++]))
            //    {
            //        set.Add(s[j++]);
            //        ans = Math.Max(ans, j - i);
            //    }
            //    else
            //    {
            //        set.Remove(s[i++]);
            //    }
            //}
            //Console.WriteLine(ans);
            //Console.ReadLine();


        }
    }
}
