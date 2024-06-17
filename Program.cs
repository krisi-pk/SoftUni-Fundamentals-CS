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


            //stack and queue 6
            string command = Console.ReadLine();
            Queue<string> queue = new Queue<string>();
            bool isPaid = false;
            while (!command.Equals("End"))
            {
                if (command.Equals("Paid"))
                {
                    foreach (string s in queue)
                    {
                        Console.WriteLine(s);
                    }
                    queue.Clear();
                }
                else {
                    queue.Enqueue(command);
                }
                command = Console.ReadLine();
            }

            if (command.Equals("End"))
            {
                Console.WriteLine(queue.Count + " people remaining.");
            }


            Console.ReadLine();
        }
    }
}
