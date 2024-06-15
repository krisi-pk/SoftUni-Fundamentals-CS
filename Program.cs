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

            //fundamentals list 3
            int guests = Int32.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            List<string> guestList = new List<string>();

            for (int i = 0; i < guests; i++)
            {
                string[] inputArr = input.Split(' ').ToArray();
                if (inputArr[2].Equals("going!"))
                {
                    if (guestList.Contains(inputArr[0]))
                    {
                        Console.WriteLine(inputArr[0] + " is already in the list!");
                    }
                    else
                    {
                        guestList.Add(inputArr[0]);
                    }
                }
                else
                {
                    if (guestList.Contains(inputArr[0]))
                    {
                        guestList.Remove(inputArr[0]);
                    }
                    else
                    {
                        Console.WriteLine(inputArr[0] + " is not in the list!");
                    }
                }
                input = Console.ReadLine();
            }
            foreach (string s in guestList)
            {
                Console.WriteLine(s);
            }


            Console.ReadLine();
        }
    }
}
