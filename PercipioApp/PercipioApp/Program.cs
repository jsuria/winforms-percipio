using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercipioApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int argument = Int32.Parse(args[1]);

            int argument = 256;

            if(Compare(argument))
            {
                Console.WriteLine("Bigger as sh**");
            }
            else
            {
                Console.WriteLine("Ain\'t that cute....BUT IT\'S WRONG!");
            }

            HasFaveBand("Alice in Chains");

            Console.WriteLine(Randoms(0, 50));
        }

        private static void HasFaveBand(string band)
        {
            switch (band)
            {
                case "Dire Straits":
                    Console.WriteLine("Sultans of swing...");
                    break;
                case "Jimi Hendrix":
                    Console.WriteLine("Yeah, she\'s walkin' through the clouds...");
                    break;
                case "Alice in Chains":
                    Console.WriteLine("Won't...");
                    break;
                default:
                    Console.WriteLine("None of these fit the bill!");
                    break;
            }
        }

        private static bool Compare(int num)
        {
            if (num > 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static int Randoms(int min, int max)
        {
            Random num = new Random();
            return num.Next(min, max);
        }
    }
}
