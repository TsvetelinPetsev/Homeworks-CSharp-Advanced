using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LastDigitNumber
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        GetLastDigitAsWord(n);
    }
    static void GetLastDigitAsWord(int number)
    {
        string[] words = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        int digit = number % 10;
        Console.WriteLine(words[digit]);
    }
}