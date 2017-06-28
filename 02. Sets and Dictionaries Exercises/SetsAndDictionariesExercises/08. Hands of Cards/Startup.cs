using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Hands_of_Cards
{
    class Startup
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, HashSet<string>> hands = new Dictionary<string, HashSet<string>>();

            while (input != "JOKER")
            {
                string[] arrInput = input.Split(new string[] { ": " }, StringSplitOptions.RemoveEmptyEntries);
                string name = arrInput[0];

                List<string> cards = arrInput[1]
                    .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (!hands.ContainsKey(name))
                {
                    hands[name] = new HashSet<string>();

                    foreach (var item in cards)
                    {
                        hands[name].Add(item);
                    }
                }

                foreach (var item in cards)
                {
                    hands[name].Add(item);
                }

                input = Console.ReadLine();
            }


            foreach (var hand in hands)
            {
                Console.WriteLine($"{hand.Key}: {CalculateHand(hand.Value)}");
            }
        }

        private static int CalculateHand(HashSet<string> value)
        {
            int sume = 0;

            foreach (var item in value)
            {
                char power = item[0];
                char type = item[item.Length - 1];

                int p = 0;
                int t = 0;

                switch (power)
                {
                    case '2': p = 2; break;
                    case '3': p = 3; break;
                    case '4': p = 4; break;
                    case '5': p = 5; break;
                    case '6': p = 6; break;
                    case '7': p = 7; break;
                    case '8': p = 8; break;
                    case '9': p = 9; break;
                    case '1': p = 10; break;
                    case 'J': p = 11; break;
                    case 'Q': p = 12; break;
                    case 'K': p = 13; break;
                    case 'A': p = 14; break;
                    default:break;
                }

                switch (type)
                {
                    case 'S': t = 4; break;
                    case 'H': t = 3; break;
                    case 'D': t = 2; break;
                    case 'C': t = 1; break;
                    default: break;
                }

                sume = sume + (p * t);
            }

            return sume;
        }

        //private static string[] cards;
        //private static string[] multiplier;
        //
        //static void Main()
        //{
        //    var input = string.Empty;
        //    var people = new Dictionary<string, HashSet<string>>();
        //    cards = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        //    multiplier = new string[] { "C", "D", "H", "S" };
        //
        //    while ((input = Console.ReadLine()) != "JOKER")
        //    {
        //        var tokens = input.Split(':');
        //        var player = tokens[0];
        //        var playerCards = tokens[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        //
        //        if (people.ContainsKey(player))
        //        {
        //            people[player].UnionWith(playerCards);
        //        }
        //        else
        //        {
        //            people.Add(player, new HashSet<string>(playerCards));
        //        }
        //    }
        //
        //    foreach (var player in people.Keys)
        //    {
        //        var playerScore = CalculateScore(people[player]);
        //        Console.WriteLine($"{player}: {playerScore}");
        //    }
        //}
        //
        //private static int CalculateScore(HashSet<string> playerCards)
        //{
        //    var cardsScore = 0;
        //
        //    foreach (var card in playerCards)
        //    {
        //        var tempScore = (Array.IndexOf(cards, card.Remove(card.Length - 1)) + 2) *
        //                        (Array.IndexOf(multiplier, card[card.Length - 1].ToString()) + 1);
        //        cardsScore += tempScore;
        //    }
        //
        //    return cardsScore;
        //}
    }
}
