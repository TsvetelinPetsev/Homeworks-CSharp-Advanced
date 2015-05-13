using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SequencesOfEqualStrings
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');
        var groups = input.GroupBy(name => name);
        foreach (var group in groups)
        {
            Console.WriteLine(string.Join(" ", group));
        }
    }
}