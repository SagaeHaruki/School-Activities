using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BegGive
{
    public class Program
    {
        static void Main(string[] args)
        {
            int wallet = 0;
            while (true)
            {
               
                Console.WriteLine("Command List: " +
                    "\nbeg - to beg a money" +
                    "\ngamble - to gamble all your money" +
                    "\nend - to end the game" +
                    "\n");
                Console.Write("Enter a Command: ");
                string input = Console.ReadLine();
                if(input == "beg")
                {
                    Random rand = new Random();
                    int amt = rand.Next(0, 120);
                    int newWallet = wallet + amt;
                    wallet = newWallet;
                    Console.WriteLine("You've begged and got: " + amt + " Coins!\n" +
                        "Your new balance is: " + wallet + "\n");

                }
                else if(input == "gamble")
                {
                    Console.Write("Enter your winning number between 0 - 10: ");
                    int numInpt;
                    Random rand = new Random();
                    int gambleNum = rand.Next(0, 10);
                    if (int.TryParse(Console.ReadLine(), out numInpt))
                    {
                        Console.WriteLine("The winning number is: " + gambleNum);
                        if (numInpt == gambleNum)
                        {
                            Console.WriteLine("You win!" +
                                "\nYour balance is doubled!" +
                                "\n");
                            int amt = wallet + wallet;
                            wallet = amt;
                        }
                        else
                        {
                            Console.WriteLine("You lost!" +
                                "\n");
                            int amt = wallet - wallet;
                            wallet = amt;
                        }
                    }
                }
                else if(input == "end")
                {
                    return;
                }
            }
        }
    }
}
