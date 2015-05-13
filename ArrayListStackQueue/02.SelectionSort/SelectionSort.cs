using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SelectionSort
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        int[] numbers = new int[input.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(input[i]);
        }
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] > numbers[j])
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }
        foreach (var i in numbers)
        {
            Console.Write(i + " ");
        }
    }
}