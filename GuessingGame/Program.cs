using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = rand.Next(1, 100);
            Console.Write("Number of tries: ");
            int tryCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < tryCount;)
            {
                Console.WriteLine("Number of tries: " + i + " of " + tryCount);
                Console.Write("Guess a Number: ");
                int numInpt;
                if (int.TryParse(Console.ReadLine(), out numInpt))
                {
                    if (numInpt < number)
                    {
                        Console.WriteLine("Higher!");
                        i++;
                    }
                    else if (numInpt > number)
                    {
                        Console.WriteLine("Lower!");
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Nice Guess! the number is: " + number);
                        Console.ReadKey();
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Enter a Valid Number:");
                }
            }
        }
    }
}
