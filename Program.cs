using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] numbers = input.Split().Select(int.Parse).ToArray();
            double average = numbers.Average();
            var filteredNumbers = numbers.Where(num => num > average);
            var result = filteredNumbers.OrderByDescending(num => num).Take(5);

            {

                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
