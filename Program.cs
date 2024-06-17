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

            //1
            int[] sizes = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.None)
                .Select(int.Parse)
                .ToArray();
            int rows = sizes[0];
            int cols = sizes[1];
            int[,] array = new int[rows, cols];
            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                int[] nums = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.None)
                .Select(int.Parse)
                .ToArray();
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = nums[j];
                    sum = sum + nums[j];
                }
            }
            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);


            Console.ReadLine();
        }
    }
}
