using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            while (true)
            {
                string num = random.Next().ToString();

                if (num[0] == '1')
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (num[0] == '2')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (num[0] == '3')
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (num[0] == '4')
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (num[0] == '5')
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                else if (num[0] == '6')
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (num[0] == '7')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }

                Console.Clear();

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"ДРОЗДОВ молодец");
                }

                Thread.Sleep(100);
            }
        }
    }
}
