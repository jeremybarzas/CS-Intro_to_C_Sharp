using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> allmaplayas = new List<int>();
            Random random = new Random();
           
            int plyrChoice = -1;
       
            while (plyrChoice != 0)
            {
                Console.WriteLine("1) Rock\n2) Paper\n3) Scissors\n0) Quit\n");

                Console.WriteLine("Type the number of your choice:");

                plyrChoice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("\n");

                if (plyrChoice == 1)
                    Console.WriteLine("You chose Rock.\n");

                else if (plyrChoice == 2)
                    Console.WriteLine("You chose Paper.\n");

                else if (plyrChoice == 3)
                    Console.WriteLine("You chose Scissors.\n");

                else if (plyrChoice == 0)
                    Console.WriteLine("You chose to end the game.\n");

                int cpuChoice = random.Next(1, 4);

                if (cpuChoice == 1)
                    Console.WriteLine("Computer chose Rock.\n");

                else if (cpuChoice == 2)
                    Console.WriteLine("Computer chose Paper.\n");

                else if (cpuChoice == 3)
                    Console.WriteLine("Computer chose Scissors.\n");

                if (plyrChoice == cpuChoice)
                    Console.WriteLine("It was a Tie.\n");

                else if (plyrChoice == 1 && cpuChoice == 2)
                {
                    Console.WriteLine("Paper beats rock you lose!.\n");
                }
                else if (plyrChoice == 1 && cpuChoice == 3)
                {
                    Console.WriteLine("Rock beats scissors you win!.\n");
                }
                else if (plyrChoice == 2 && cpuChoice == 1)
                {
                    Console.WriteLine("Paper beats rock you win!.\n");
                }
                else if (plyrChoice == 2 && cpuChoice == 3)
                {
                    Console.WriteLine("Scissors beat paper you lose!.\n");
                }
                else if (plyrChoice == 3 && cpuChoice == 1)
                {
                    Console.WriteLine("Rock beats Scissors you lose!.\n");
                }
                else if (plyrChoice == 3 && cpuChoice == 2)
                {
                    Console.WriteLine("Scissors beat paper you win!.\n");
                }
            }
            Console.ReadLine();
        }
    }
}