using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;

namespace Tutorials
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var watch = Stopwatch.StartNew();
            //Call Problem{problem number} method here for result
            watch.Stop();
            Console.WriteLine(watch.Elapsed);
        }

        public static void Problem1()
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);

        }

        public static void Problem2()
        {
            long f1 = 1;
            long f2 = 1;
            long result = 0;
            long sum = 0;

            while (result < 4_000_000)
            {
                if (result % 2 == 0)
                {
                    sum += result;
                }

                result = f1 + f2;
                f2 = f1;
                f1 = result;
            }
            Console.WriteLine(sum);
        }

        public static void Problem3()
        {
            const long NUMBER = 600851475143;
            int max = 0;
            foreach (var c in CustomMath.Factors(NUMBER)) //CustomMath methods are in another file
            {
                if (CustomMath.IsPrime(c))
                {
                    if (c > max)
                    {
                        max = c; 
                    }
                }
            }
            Console.WriteLine(max);
        }

        public static void Problem4()
        {
            int largestPalindrome = 0;
            for (int i = 999; i > 99; i--)
            {
                for (int j = 999; j > 99; j--)
                {
                    if (CustomMath.IsPalindrome(i * j))
                    {
                        if (i * j >largestPalindrome)
                        {
                            largestPalindrome = i * j;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(largestPalindrome);
        }

        public static void Problem5()
        {
            int n = 1;
            while (true)
            {
                if (CustomMath.IsDivisibleForEachN(n, 20))
                {
                    break;
                }

                n++;
            }
            Console.WriteLine(n); //returns smallest number which can be divided by every natural number up to 20
        }

        public static void Problem6()
        {
            const int N = 100;
            int sumsqr = 0, sqrsum = 0;
            for (int i = 1; i <= N; i++)
            {
                sqrsum += i;
                sumsqr += i * i;
            }
            Console.WriteLine(sqrsum * sqrsum - sumsqr);
        }

        public static void Problem7()
        {
            int n = 2;
            const int N = 10001;
            int ctr = 0;
            while (ctr < N)
            {
                if (CustomMath.IsPrime(n))
                {
                    ctr++;
                }

                n++;
            }

            n--;
            Console.WriteLine(n);
        }

        public static void Problem10()        /*The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
                                                Find the sum of all the primes below two million.*/
        {
            int n = 2;
            long sum = 0;
            while (n < 2_000_000)
            {
                if (CustomMath.IsPrime(n))
                {
                    sum += n;
                }

                n++;
            }
            Console.WriteLine(sum);
        }
    }
}