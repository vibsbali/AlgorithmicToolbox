using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = args.First();
            var hash = new Dictionary<int, int>();
            for (int i = 0; i < number.Length; i++)
            {
                var numberToAdd = int.Parse(number[i].ToString());
                if (hash.ContainsKey(numberToAdd))
                {
                    hash[numberToAdd] += 1;
                }
                else
                {
                    hash.Add(numberToAdd, 1);
                }
            }

            var largestNumberAsString = "";
            for (int i = 9; i >= 0; i--)
            {
                if (hash.ContainsKey(i))
                {
                    for (int j = 0; j < hash[i]; j++)
                    {
                        largestNumberAsString += i;
                    }
                }
            }

            var finalSalary = decimal.Parse(largestNumberAsString);
            Console.WriteLine(finalSalary);
        }
    }
}
