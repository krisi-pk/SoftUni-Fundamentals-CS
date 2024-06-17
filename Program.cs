using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SoftUniList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //5
            int[] sizes = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.None)
                .Select(int.Parse)
                .ToArray();
            int rows = sizes[0];
            int cols = sizes[1];
            int[,] array = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] nums = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.None)
                .Select(int.Parse)
                .ToArray();
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = nums[j];
                }
            }

            int maxSum = 0;
            int currSum = 0;
            int keyRow = 0;
            int keyCol = 0;
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = 0; j < cols - 1; j++)
                {
                    currSum = array[i, j] + array[i, j + 1] + array[i + 1, j] + array[i + 1, j + 1];
                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        keyRow = i;
                        keyCol = j;
                    }
                }
            }
            Console.WriteLine(array[keyRow, keyCol] + " " + array[keyRow, keyCol + 1]);
            Console.WriteLine(array[keyRow + 1, keyCol] + " " + array[keyRow + 1, keyCol + 1]);
            Console.WriteLine(maxSum);


            Console.ReadLine();
        }
    }
}
