using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumberCalculations
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a set of double numbers:");
        double[] doubleNum = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse).ToArray();
        Console.WriteLine("Min: {0}, Max: {1}, Sum: {2}, Avg: {3}, Product: {4}\n", 
            CalcMin(doubleNum), CalcMax(doubleNum), CalcSum(doubleNum), CalcAvg(doubleNum), CalcProduct(doubleNum));

        Console.WriteLine("Enter a set of decimal numbers:");
        decimal[] decimalNum = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(decimal.Parse).ToArray();
        Console.WriteLine("Min: {0}, Max: {1}, Sum: {2}, Avg: {3}, Product: {4}\n", 
            CalcMin(decimalNum), CalcMax(decimalNum), CalcSum(decimalNum), CalcAvg(decimalNum), CalcProduct(decimalNum));
    }
    static double CalcMin(double[] numbers)
    {
        double min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }    
        }
        return min;
    }
    static double CalcMax(double[] numbers)
    {
        double max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }
    static double CalcSum(double[] numbers)
    {
        double sum = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    static double CalcAvg(double[] numbers)
    {
        return CalcSum(numbers) / numbers.Length;
    }
    static double CalcProduct(double[] numbers)
    {
        double product = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }
    static decimal CalcMin(decimal[] numbers)
    {
        decimal min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }
        return min;
    }
    static decimal CalcMax(decimal[] numbers)
    {
        decimal max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }
        return max;
    }
    static decimal CalcSum(decimal[] numbers)
    {
        decimal sum = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    static decimal CalcAvg(decimal[] numbers)
    {
        return CalcSum(numbers) / numbers.Length;
    }
    static decimal CalcProduct(decimal[] numbers)
    {
        decimal product = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            product *= numbers[i];
        }
        return product;
    }
}