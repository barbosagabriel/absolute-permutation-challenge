using System;
using System.Text;

namespace AbsolutePermutation
{
    public class Program
    {
        /// <summary>
        /// Return an integer that represents the smallest lexicographically permutation, or -1 if there is none.
        /// </summary>
        /// <returns>Int array with lexicographically smallest absolute permutation, or -1</returns>
        /// <param name="n">The upper bound of natural numbers to consider, inclusive</param>
        /// <param name="k">The integer difference between each element and its index</param>
        public static int[] AbsolutePermutation(int n, int k)
        {
            var result = new int[n];
            var signal = 1;

            var aux = 0;
            for (int i = 1; i <= n; i++)
            {
                if (k == aux)
                {
                    signal *= -1;
                    aux = 0;
                }

                int value = i + (k * signal);
                if (value < 1 || value > n)
                {
                    return new int[] { -1 };
                }

                result[i-1] = value;
                aux++;
            }

            return result;
        }

        public static void Main()
        {
            var completeResult = new StringBuilder();

            Console.WriteLine("Input:");
            var t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string[] nk = Console.ReadLine().Split(' ');

                var n = Convert.ToInt32(nk[0]);

                var k = Convert.ToInt32(nk[1]);

                int[] result = AbsolutePermutation(n, k);

                completeResult.AppendLine(string.Join(" ", result));
            }

            Console.WriteLine($"Output:\n{completeResult}");
        }
    }
}
