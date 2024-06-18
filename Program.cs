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


            //dict 3 

            Dictionary<string, Dictionary<string, int>> playerPoints = new Dictionary<string, Dictionary<string, int>>();

            string input = Console.ReadLine();
            while (!input.Equals("Season end"))
            {
                if (input.Contains("->"))
                {
                    string[] tokens = input.Split(new string[] { " -> " }, StringSplitOptions.None);
                    string player = tokens[0];
                    string position = tokens[1];
                    int skill = Int32.Parse(tokens[2]);

                    if (!playerPoints.ContainsKey(player))
                    {
                        playerPoints.Add(player, new Dictionary<string, int>());
                        playerPoints[player].Add(position, skill);
                    }
                    else if (!playerPoints[player].ContainsKey(position))
                    {
                        playerPoints[player].Add(position, skill);
                    }
                    else if (playerPoints[player][position] < skill)
                    {
                        playerPoints[player][position] = skill;
                    }
                }
                else
                {
                    string[] tokens = input.Split(new string[] { " vs " }, StringSplitOptions.None);
                    string first = tokens[0];
                    string second = tokens[1];
                    if (playerPoints.ContainsKey(first) && playerPoints.ContainsKey(second))
                    {
                        int totalPointF = 0;
                        int totalPointS = 0;
                        bool fight = false;
                        foreach (KeyValuePair<string, int> placeF in playerPoints[first])
                        {
                            foreach (KeyValuePair<string, int> placeS in playerPoints[second])
                            {
                                if (placeF.Key.Equals(placeS.Key))
                                {
                                    totalPointF += placeF.Value;
                                    totalPointS += placeS.Value;
                                    fight = true;
                                }
                            }
                        }
                        if (fight == true)
                        {
                            if (totalPointF > totalPointS)
                            {
                                playerPoints.Remove(second);
                            }
                            else if (totalPointS > totalPointF)
                            {
                                playerPoints.Remove(first);
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, Dictionary<string, int>> pl in playerPoints)
            {
                int points = 0;
                foreach (KeyValuePair<string, int> power in pl.Value)
                {
                    points = points + power.Value;
                }
                Console.WriteLine("{0}: {1} skill", pl.Key, points);

                var orderedPoints =
                    from po in pl.Value
                    orderby po.Value descending
                    select po;

                foreach (var place in orderedPoints)
                {
                    Console.WriteLine("- {0} <::> {1}", place.Key, place.Value);
                }
            }

            Console.ReadLine();
        }
    }
}
