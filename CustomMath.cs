using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Tutorials
 {
     public static class CustomMath
     {
         /*public static string TruncateString(string x, int length)
         {
             return x.Substring(0, Math.Min(x.Length, length));
         }*/

         public static bool IsPalindrome(int n)
         {
             string str = n.ToString();
             int digitCount = str.Length;
             string firstPart = str.Substring(0, digitCount / 2);
             string secondPart = str.Substring(digitCount / 2, digitCount / 2);
             string secondPartReversed1 = Reverse(secondPart);

             if (firstPart == secondPartReversed1)
                 return true;
             return false;
         }
         public static string Reverse(string s)
         {
             char[] charArray = s.ToCharArray();
             Array.Reverse( charArray );
             return new string( charArray );
         }
         public static bool IsDivisibleForEachN(int x, int n) /*Checks if number can be divided by every 
                                                                 natural number until n without a remainder*/ 
         {
             int y = 0;
             for (int i = 1; i <= n; i++)
             {
                 if (x % i == 0)
                 {
                     y++;
                 }
             }

             if (y == n)
             {
                 return true;
             }

             return false;
         }
         public static int Sum(int n) //Sum of first n numbers
         {
             int sum = 0;
             for (int i = 1; i < n; i++)
             {
                 sum += i;
             }

             return sum;
         }
         public static List<int> Factors(long n)
         {
             int x = (int)Math.Floor(Math.Sqrt(n));
             List<int> list = new List<int>();
             for (int i = 1; i < x; i++)
             {
                 if (n % i == 0)
                 {
                     list.Add(i);            /*Adds a factor and a number divided 
                                                by that factor to list*/
                     list.Add((int)n / i);
                 }
             }

             return list;
         }

         public static bool IsPrime(long n)
         {
             int x = (int) Math.Floor(Math.Sqrt(n));

             if (n == 1)
             {
                 return false;
             }

             if (n == 2)
             {
                 return true;
             }

             for (int i = 2; i <= x; ++i)
             {
                 if (n % i == 0)        /*checks if number can be divided by any 
                                             number until the sqrt of that number*/
                 {
                     return false;
                 }
             }

             return true;
         }
     }
 }