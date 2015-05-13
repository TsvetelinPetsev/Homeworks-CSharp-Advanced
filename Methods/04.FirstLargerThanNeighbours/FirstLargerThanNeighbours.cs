using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FirstLargerThanNeighbours
{
    static void Main(string[] args)
    {
        int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
        int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
        int[] sequenceThree = { 1, 1, 1 };

        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceOne));
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceTwo));
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceThree));
    }
    static bool IsLargerThanNeighbours(int[] nums, int i)
    {
        bool isLarger = false;
        if (i == 0)
        {
            isLarger = nums[i] > nums[i + 1];
        }
        else if (i > 0 && i < nums.Length - 1)
        {
            isLarger = nums[i] > nums[i - 1] && nums[i] > nums[i + 1];
        }
        else
        {
            isLarger = nums[i] > nums[i - 1];
        }
        return isLarger;
    }
    static int GetIndexOfFirstElementLargerThanNeighbours(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            if (IsLargerThanNeighbours(nums, i))
            {
                return i;
            }
        }
        return -1;
    }
}