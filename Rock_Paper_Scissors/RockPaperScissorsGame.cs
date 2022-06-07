using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    class RockPaperScissorsGame
    {
        private Random rng;
        private int wins;
        private int losses;
        private int ties;

        public RockPaperScissorsGame()
        {
            rng = new Random();

        }
        public void Play()
        {
            string userChoice;
            userChoice = PromptUser();
        }

        private string PromptUser()
        {
            while(true)
            {
                Console.Write("Enter your choice: (R)ock, (P)aper, (S)cissors, or (Q)uit: ");
                string choice = Console.ReadLine();

                if (choice == "R" || choice == "P" || choice == "S" || choice == "Q") return choice;
                else Console.WriteLine("That was not a valid choice");
            }
        }
    }

}
