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
            //fundamentals list 2.Change List
            List<string> input = new List<string>();
            input = Console.ReadLine().Split(' ').ToList();
            List<int> nums = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                nums.Add(Int32.Parse(input[i]));
            }
            string zap = Console.ReadLine();
            while (!zap.Equals("end"))
            {
                string[] zapArr = zap.Split(' ').ToArray();
                if (zapArr[0].Equals("Delete"))
                {
                    while (nums.Contains(Int32.Parse(zapArr[1])))
                    {
                        nums.Remove(Int32.Parse(zapArr[1]));
                    }
                }
                else if (zapArr[0].Equals("Insert"))
                {
                    nums.Insert(Int32.Parse(zapArr[2]), Int32.Parse(zapArr[1]));
                }
                zap = Console.ReadLine();
            }
            foreach (int n in nums)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
