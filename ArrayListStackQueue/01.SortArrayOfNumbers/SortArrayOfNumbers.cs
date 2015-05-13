using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortArrayOfNumbers
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] numbers = new int[input.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }
        Array.Sort(numbers);
        foreach (var i in numbers)
        {
            Console.Write(i + " ");
        }
    }
}