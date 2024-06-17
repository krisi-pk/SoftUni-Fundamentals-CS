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

            //fundamentals list pokemon
            List<int> pokemons = Console.ReadLine()
                .Split(' ')
                .Select(Int32.Parse)
                .ToList();
            int sum = 0;
            while (pokemons.Count > 0)
            {
                int command = Int32.Parse(Console.ReadLine());
                int current = 0;
                if (command >= 0 && command < pokemons.Count)
                {
                    current = pokemons.ElementAt(command);
                    pokemons.RemoveAt(command);  
                }
                else if (command < 0)
                {
                    current = pokemons[0];
                    pokemons[0] = pokemons[pokemons.Count - 1];
                }
                else if (command > (pokemons.Count - 1))
                {
                    current = pokemons[pokemons.Count - 1];
                    pokemons[pokemons.Count - 1] = pokemons[0];
                }
                sum = sum + current;
                for (int i = 0; i < pokemons.Count; i++)
                {
                    if (pokemons[i] <= current)
                    {
                        pokemons[i] = pokemons[i] + current;
                    }
                    else
                    {
                        pokemons[i] = pokemons[i] - current;
                    }
                }
            }
            Console.WriteLine(sum);


            Console.ReadLine();
        }
    }
}
