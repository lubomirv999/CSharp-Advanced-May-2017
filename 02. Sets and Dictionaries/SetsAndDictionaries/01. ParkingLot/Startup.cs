using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.ParkingLot
{
    class Startup
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var parkingLot = new SortedSet<string>();

            while (input != "END")
            {
                var inputParams = Regex.Split(input, ", ");

                if (inputParams[0] == "IN")
                {
                    parkingLot.Add(inputParams[1]);
                }
                else
                {
                    parkingLot.Remove(inputParams[1]);
                }

                input = Console.ReadLine();
            }

            if (parkingLot.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in parkingLot)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
