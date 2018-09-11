using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

            numbers.Remove(1);
            numbers.Remove(2);
            numbers.Remove(4);

            numbers.Add(1);
            numbers.Add(7);

            foreach (int num in numbers) 
            {
	            Console.Write(num + " ");
            }
        }
    }
}
