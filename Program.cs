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


            //hashset 7

            string command = Console.ReadLine();
            HashSet<string> parcking = new HashSet<string>();
            while (!command.Equals("END"))
            {
                string[] tokens = command.Split(new string[] { ", " }, StringSplitOptions.None);
                string activity = tokens[0];
                string car = tokens[1];
                if (activity.Equals("IN"))
                {
                    parcking.Add(car);
                }
                else
                {
                    parcking.Remove(car);
                }
                command = Console.ReadLine();
            }
            if (parcking.Count <= 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else {
                foreach (string c in parcking)
                {
                    Console.WriteLine(c);
                }
            }
            
            Console.ReadLine();
        }
    }
}
