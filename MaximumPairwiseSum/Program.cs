using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumPairwiseSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            Console.WriteLine(solution.GetResult(new int[]{68165, 20242, 87637, 74297, 82935, 87637 }));
        }
    }

    class Solution
    {
        public ulong GetResult(int[] A)
        {
            if (A.Length < 2)
            {
                throw new InvalidOperationException("Insufficient input size");
            }
            var a = -1;
            var b = -2;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > b)
                {
                    if (A[i] > a)
                    {
                        a = A[i];
                    }
                    else
                    {
                        b = A[i];
                    }
                }
            }

            return (ulong)a * (ulong)b;
        }
    }
}
