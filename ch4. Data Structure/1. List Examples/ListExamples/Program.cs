using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            numbers.Add(6);

            Console.WriteLine(numbers.Count); // 6
            Console.WriteLine(numbers.IndexOf(5)); //4
            Console.WriteLine(numbers.Contains(7)); // false
            numbers[0] = 7;
            numbers.Remove(3); // { 7, 2, 3, 5, 6 } 

            int a = numbers[6]; // throws ArgumentOutOfRangeException
        }
    }
}
