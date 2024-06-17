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


            //1zad
            int[] numbers = Console.ReadLine()
                                    .Split(' ')
                                    .Select(Int32.Parse)
                                    .ToArray();

            Dictionary<int, int> numbersCount = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];
                if (!numbersCount.ContainsKey(currNum))
                {
                    numbersCount.Add(currNum, 1);
                }
                else
                {
                    numbersCount[currNum]++;
                }
            }

            foreach (var currNum in numbersCount)
            {
                Console.WriteLine(currNum.Key + "-> " + currNum.Value);
            }

            Console.ReadLine();
        }
    }
}
