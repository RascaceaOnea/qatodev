using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratePowerSetOfGivenSet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> originalSet = new List<char>();
            List<List<char>> powerSet = new List<List<char>>();

            originalSet.Add('a');
            originalSet.Add('b');
            originalSet.Add('c');
            originalSet.Add('d');
            originalSet.Add('e');

            int setLenght = originalSet.Count();

            for (int i = 1; i <= Math.Pow(2, setLenght); i++)
            {
                List<char> bufferSet = new List<char>();
                int j = 0;
                for (j = 0; j < setLenght; j++)
                {
                    int compareNr = Convert.ToInt32(Math.Pow(2, j));
                    if ((i & compareNr) == compareNr)
                    {
                        bufferSet.Add(originalSet[j]);
                    }
                }

                powerSet.Add(bufferSet);
            }

            PrintPowerSet(powerSet);
        }

        public static void PrintPowerSet(List<List<char>> powerSet)
        {
            foreach (List<char> l in powerSet)
            {
                Console.Write("{ ");
                foreach (char c in l)
                {
                    Console.Write(c);
                    Console.Write(" ");
                }
                Console.Write("}\n");
            }
            Console.ReadKey();
        }
    }
}
