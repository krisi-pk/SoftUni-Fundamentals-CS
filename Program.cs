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

            //3
            int n = Int32.Parse(Console.ReadLine());
            int[,] array = new int[n, n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = nums[j];
                    if (i == j)
                    {
                        sum = sum + nums[j];
                    }
                }
            }
            Console.WriteLine(sum);


            Console.ReadLine();
        }
    }
}
