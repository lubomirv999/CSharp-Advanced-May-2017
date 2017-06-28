using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sequence_With_Queue
{
    class Startup
    {
        static void Main(string[] args)
        {
            var num = long.Parse(Console.ReadLine());
            Queue<long> nums = new Queue<long>();

            nums.Enqueue(num);

            StringBuilder resultSequence = new StringBuilder();

            for (int i = 0; i < 50; i++)
            {
                var firstElement = nums.Peek();
                nums.Enqueue(firstElement + 1);
                nums.Enqueue(2 * firstElement + 1);
                nums.Enqueue(firstElement + 2);

                resultSequence.Append(nums.Dequeue() + " ");
            }
            Console.WriteLine(resultSequence.ToString().TrimEnd());
        }
    }
}
