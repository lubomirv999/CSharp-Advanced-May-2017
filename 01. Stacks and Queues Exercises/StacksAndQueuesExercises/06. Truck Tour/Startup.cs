using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Truck_Tour
{
    class Startup
    {
        static void Main(string[] args)
        {
            int numberOfPetrolPumps = int.Parse(Console.ReadLine());
            Queue<PetrolPump> pumps = new Queue<PetrolPump>();

            for (int i = 0; i < numberOfPetrolPumps; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                long amountOfPetrol = long.Parse(input[0]);
                long distanceToPump = long.Parse(input[1]);

                pumps.Enqueue(new PetrolPump()
                {
                    AmountOfPetrol = amountOfPetrol,
                    DistanceToNextPump = distanceToPump,
                    Index = i
                });
            }

            while (true)
            {
                var startPump = pumps.Dequeue();
                pumps.Enqueue(startPump);

                if (startPump.AmountOfPetrol < startPump.DistanceToNextPump)
                {
                    continue;
                }

                PetrolTank currentTank = new PetrolTank();
                currentTank.AmountOfPetrol = startPump.AmountOfPetrol - startPump.DistanceToNextPump;

                bool IsCycleCompleted = false;

                while (true)
                {
                    var currentPump = pumps.Dequeue();
                    pumps.Enqueue(currentPump);

                    if (currentPump.Index == startPump.Index)
                    {
                        IsCycleCompleted = true;
                        break;
                    }

                    currentTank.AmountOfPetrol += currentPump.AmountOfPetrol;

                    if (currentTank.AmountOfPetrol < currentPump.DistanceToNextPump)
                    {
                        break;
                    }

                    currentTank.AmountOfPetrol -= currentPump.DistanceToNextPump;
                }

                if (IsCycleCompleted)
                {
                    Console.WriteLine(startPump.Index);
                    break;
                }
            }
        }
    }

    public class PetrolPump
    {
        public long AmountOfPetrol { get; set; }

        public long DistanceToNextPump { get; set; }

        public long Index { get; set; }
    }

    public class PetrolTank
    {
        public long AmountOfPetrol { get; set; }
    }
}
