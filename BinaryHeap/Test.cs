using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryHeap
{
    class Test
    {
        static void Main(string[] args)
        {
            Random rnd = new Random(0);

            Console.WriteLine("\nInsertion Order\n");
            BinaryHeap<Int64> heap = new BinaryHeap<Int64>(true);
            for (int i = 0; i < 100; i++)
            {
                Int64 toAdd = rnd.Next(-10, 300);
                heap.Insert(toAdd);
                Int64 currentPeak = heap.Peek();
                Console.WriteLine("Added "+toAdd+" currentPeak "+currentPeak);
            }


            Console.WriteLine("\nExtraction Order\n");
            while (heap.isEmpty() == false)
            {
                Console.WriteLine(heap.ExtractRootNode());
            }

            Console.WriteLine("Press enter to close...");
            Console.ReadLine();

        }
    }
}
