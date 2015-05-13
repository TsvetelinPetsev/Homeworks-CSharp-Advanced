using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MatrixShuffling
{
    static string[,] matrix;
    static void Main(string[] args)
    {
        int row = int.Parse(Console.ReadLine());
        int col = int.Parse(Console.ReadLine());
        matrix = new string[row, col];
        bool isEnd = false;

        for (int a = 0; a < row; a++)
        {
            for (int b = 0; b < col; b++)
            {
                Console.Write("Enter [{0}, {1}] element: ", a, b);
                matrix[a, b] = Console.ReadLine();
            }
        }
        while (!isEnd)
        {
            string swap = Console.ReadLine();
            if (swap == "END")
            {
                isEnd = true;
                break;
            }
            string[] input = swap.Split().ToArray();
            if (input[0] != "swap" && input.Length != 5)
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                int x1 = int.Parse(input[1]);
                int y1 = int.Parse(input[2]);
                int x2 = int.Parse(input[3]);
                int y2 = int.Parse(input[4]);
                if ((x1 > row || x2 > row) || (y1 > col || y2 > col))
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    SwapElements(x1, y1, x2, y2);
                }
            }
        }
    }
    static void SwapElements(int x1, int y1, int x2, int y2)
    {
        string temp = matrix[x1, y1];
        matrix[x1, y1] = matrix[x2, y2];
        matrix[x2, y2] = temp;

        PrintMatrix();
    }
    static void PrintMatrix()
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write("{0,2} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}