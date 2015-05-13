using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CategorizeNumbers
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        double[] numbers = input.Split().Select(double.Parse).ToArray();
        List<double> roundNumbers = new List<double>();
        List<double> nonZeroFractionNumbers = new List<double>();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 1 == 0)
            {
                roundNumbers.Add(numbers[i]);
            }
            else
            {
                nonZeroFractionNumbers.Add(numbers[i]);
            }
        }
        Console.Write("[");
        for (int i = 0; i < nonZeroFractionNumbers.Count; i++)
        {
            if (nonZeroFractionNumbers[i] == nonZeroFractionNumbers.Last())
            {
                Console.Write(nonZeroFractionNumbers[i]);
            }
            else
            {
                Console.Write(nonZeroFractionNumbers[i] + ", ");
            }
        }
        Console.Write("] -> min: {0}, max: {1}, sum: {2}, avg: {3:f2}", nonZeroFractionNumbers.Min(),
            nonZeroFractionNumbers.Max(), nonZeroFractionNumbers.Sum(), nonZeroFractionNumbers.Average());
        Console.WriteLine("\n");
        Console.Write("[");
        for (int i = 0; i < roundNumbers.Count; i++)
        {
            if (roundNumbers[i] == roundNumbers.Last())
            {
                Console.Write(roundNumbers[i]);
            }
            else
            {
                Console.Write(roundNumbers[i] + ", ");
            }
        }
        Console.Write("] -> min: {0}, max: {1}, sum: {2}, avg: {3:f2}", roundNumbers.Min(),
            roundNumbers.Max(), roundNumbers.Sum(), roundNumbers.Average());
        Console.WriteLine("\n");
    }
}