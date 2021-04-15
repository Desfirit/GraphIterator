using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphIterator
{

    /*
     Sample Input 
9
0 2
0 3
0 5
2 4
2 1
3 6
4 7
5 8
s
     */
    class Program
    {
        static void Main(string[] args)
        {

            uint graphSize = GetNumber("Enter graph size (use only numbers)");
            Graph graph = new Graph(graphSize);

            Console.WriteLine("Enter edge in format {num} {num} for break enter 'stop'");


            (uint, uint) edge;
            string input;
            while(true)
            { 
                input = Console.ReadLine();
                try
                {
                    edge = ParseEdge(input);
                    graph.AddEdge(edge.Item1, edge.Item2);
                }
                catch (Exception)
                {
                    break;
                }
            }

            GraphObserver graphObserver = new GraphObserver();

            graph.AddEventListener(graphObserver);

            foreach(var vert in graph.GetIterator(0))
            {

            }

            Console.ReadKey();
        }

        static uint GetNumber(string mes)
        {
            uint number;
            string input;
            do
            {
                Console.WriteLine(mes);
                input = Console.ReadLine();
            } while (!uint.TryParse(input, out number));
            return number;
        }

        static (uint,uint) ParseEdge(string str)
        {
            uint number1, number2;
            var nums = str.Split(' ');

            if (nums.Length != 2)
                throw new Exception("Not edge format");
            if (!uint.TryParse(nums[0], out number1) & !uint.TryParse(nums[1], out number2))
                throw new Exception("Not numbers");


            return (number1,number2);
        }
    }
}
