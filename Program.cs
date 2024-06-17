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


            //dictionary 8

            string input = Console.ReadLine();
            Dictionary<string, string> contestPassword = new Dictionary<string, string>();

            while (!input.Equals("end of contests"))
            {
                string[] tokens = input.Split(':');
                string contest = tokens[0];
                string password = tokens[1];
                contestPassword.Add(contest, password);

                input = Console.ReadLine();
            }

            SortedDictionary<string, SortedDictionary<string, int>> studentsResults = new SortedDictionary<string, SortedDictionary<string, int>>();
            input = Console.ReadLine();

            while (!input.Equals("end of submissions"))
            {
                string[] tokens = input.Split(new string[] { "=>" }, StringSplitOptions.None);
                string contest = tokens[0];
                string password = tokens[1];
                if (!contestPassword.ContainsKey(contest) || !contestPassword[contest].Equals(password))
                {
                    input = Console.ReadLine();
                    continue;
                }
                string student = tokens[2];
                int points = Int32.Parse(tokens[3]);
                if (!studentsResults.ContainsKey(student))
                {
                    studentsResults.Add(student, new SortedDictionary<string, int>());
                    studentsResults[student].Add(contest, points);
                }
                else if (studentsResults[student].ContainsKey(contest))
                {
                    int pointsAtMoment = studentsResults[student][contest];
                    if (pointsAtMoment <= points)
                    {
                        studentsResults[student][contest] = points;
                    }
                }
                else
                {
                    studentsResults[student].Add(contest, points);
                }
                input = Console.ReadLine();
            }

            int mostPoints = 0;
            string mostSmart = "";
            int currPoint = 0;
            foreach (KeyValuePair<string, SortedDictionary<string, int>> student in studentsResults)
            {
                foreach (KeyValuePair<string, int> contest in student.Value)
                {
                    currPoint = currPoint + contest.Value;
                }
                if (currPoint > mostPoints)
                {
                    mostPoints = currPoint;
                    mostSmart = student.Key;
                }
                currPoint = 0;
            }

            Console.WriteLine("Best candidate is {0} with total {1} points.", mostSmart, mostPoints);
            Console.WriteLine("Ranking: ");
            foreach (KeyValuePair<string, SortedDictionary<string, int>> student in studentsResults)
            {
                Console.WriteLine(student.Key);
                var sortedPoints =
                    from contest in student.Value
                    orderby contest.Value descending
                    select contest;

                foreach (var s in sortedPoints)
                {
                    Console.WriteLine("#  {0} -> {1}", s.Key, s.Value);
                }
            }

            Console.ReadLine();
        }
    }
}
