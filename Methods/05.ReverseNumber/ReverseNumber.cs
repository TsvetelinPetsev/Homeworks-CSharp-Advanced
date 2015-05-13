using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseNumber
{
    static void Main(string[] args)
    {
        double input = double.Parse(Console.ReadLine());
        double reversed = GetReversedNumber(input);
        Console.WriteLine(reversed);
    }
    static double GetReversedNumber(double num)
    {
        string str = num.ToString();
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return double.Parse(new string(charArray));
    }
}