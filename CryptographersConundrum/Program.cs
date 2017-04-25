using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptographersConundrum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int days = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (i % 3 == 0)
                {
                    if (input[i] != 'P')
                    {
                        days++;
                    }
                }
                else if (i % 3 == 1)
                {
                    if (input[i] != 'E')
                    {
                        days++;
                    }
                }
                else if (i % 3 == 2)
                {
                    if (input[i] != 'R')
                    {
                        days++;
                    }
                }
            }

            Console.WriteLine(days);
        }
    }
}
