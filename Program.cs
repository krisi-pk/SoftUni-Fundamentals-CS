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


            //dictionary 2

            int n = Int32.Parse(Console.ReadLine());
            Dictionary<string, List<double>> dict = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                string student = tokens[0];
                double vote = double.Parse(tokens[1]);
                if (!dict.ContainsKey(student))
                {
                    dict.Add(student, new List<double>());
                }
                dict[student].Add(vote);
            }

            foreach (KeyValuePair<string, List<double>> stu in dict)
            {
                double avg = stu.Value.Sum() / stu.Value.Count;
                string prices = "";
                for (int i = 0; i < stu.Value.Count; i++)
                {
                    prices = prices + stu.Value[i].ToString() + " ";
                }
                Console.WriteLine(stu.Key + " -> " + prices + " (avg: " + avg + ")");
            }

            Console.ReadLine();
        }
    }
}
