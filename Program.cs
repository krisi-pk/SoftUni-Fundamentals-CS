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


            //stack and queue 8
            string number = Console.ReadLine();
            int num = Int32.Parse(number);
            int count = 0;
            Queue<string> cars = new Queue<string>();
            string command = Console.ReadLine();
            while (!command.Equals("end"))
            {
                if (!command.Equals("green"))
                {
                    cars.Enqueue(command);
                }
                else
                {
                    for (int i = 0; i < num; i++)
                    {
                        if (cars.Count == 0)
                        {
                            break;
                        }
                        string currCar = cars.Peek();
                        Console.WriteLine(currCar + " passed!");
                        count++;
                        cars.Dequeue();
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("{0} cars passed the crossroads.", count);


            Console.ReadLine();
        }
    }
}
