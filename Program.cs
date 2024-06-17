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


            //stack and queue 2
            int[] nums = Console.ReadLine()
                .Split(' ')
                .Select(Int32.Parse)
                .ToArray();

            Stack<int> stack = new Stack<int>();
            foreach (int n in nums)
            {
                stack.Push(n);
            }

            string command = Console.ReadLine().ToLower();
            while (!command.Equals("end"))
            {
                string[] tokens = command.Split(' ');
                if (tokens[0].Equals("add"))
                {
                    stack.Push(Int32.Parse(tokens[1]));
                    stack.Push(Int32.Parse(tokens[2]));
                }
                else
                {
                    int count = Int32.Parse(tokens[1]);
                    if (count <= stack.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }

            int sum = 0;
            foreach (int n in stack)
            {
                sum = sum + n;
            }
            Console.WriteLine("Sum: " + sum);


            Console.ReadLine();
        }
    }
}
