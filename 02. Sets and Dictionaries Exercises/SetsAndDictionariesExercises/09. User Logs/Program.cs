using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.User_Logs
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new SortedDictionary<string, Dictionary<string, int>>();
            string input;           

            while ((input = Console.ReadLine()) != "end")
            {
                var tokens = input.Split(' ');
                var ip = tokens[0].Split('=')[1];
                var user = tokens[2].Split('=')[1];

                if (users.ContainsKey(user))
                {
                    if (users[user].ContainsKey(ip))
                    {
                        users[user][ip]++;
                    }
                    else
                    {
                        users[user].Add(ip, 1);
                    }
                }
                else
                {
                    var userIps = new Dictionary<string, int>();
                    userIps.Add(ip, 1);
                    users.Add(user, userIps);
                }
            }

            foreach (var name in users.Keys)
            {
                Console.WriteLine(name + ":");
                var ips = users[name];
                Console.WriteLine(string.Join(", ", ips.Select(x => x.Key + " => " + x.Value).ToArray()) + ".");
            }

            //string input = Console.ReadLine();
            //
            //Dictionary<string, Dictionary<string, int>> usersDict = new Dictionary<string, Dictionary<string, int>>();      //<user>, <<ip>, <count>>
            //
            //while (input != "end")
            //{
            //    string[] logs = input.Split(new string[] { "IP=", " message=", " user=" }, StringSplitOptions.RemoveEmptyEntries);
            //
            //    string ip = logs[0];
            //    string user = logs[2];
            //
            //    if (!usersDict.ContainsKey(user))
            //    {
            //        usersDict[user] = new Dictionary<string, int>();
            //    }
            //
            //    if (!usersDict[user].ContainsKey(ip))
            //    {
            //        usersDict[user][ip] = 0;
            //    }
            //
            //    usersDict[user][ip]++;
            //
            //    input = Console.ReadLine();
            //}
            //
            //foreach (var user in usersDict.OrderBy(u => u.Key))
            //{
            //    List<string> ipCounter = new List<string>();
            //
            //    foreach (var ip in user.Value)
            //    {
            //        ipCounter.Add(string.Join(" => ", ip.Key, ip.Value));   //192.23.30.40 => 2
            //        //192.23.30.41 => 1
            //        //192.23.30.42 => 1
            //    }
            //
            //    Console.WriteLine($"{user.Key}:\n{string.Join(", ", ipCounter)}."); //destroyer:
            //    //192.23.30.40 => 2, 192.23.30.41 => 1, 192.23.30.42 => 1.
            //}
        }
    }
}
