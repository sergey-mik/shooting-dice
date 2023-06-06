using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            int userInputRoll;
            bool isValidInput;

            do
            {
                Console.Write($"{Name}, please enter a number for your roll: ");
                string input = Console.ReadLine();
                isValidInput = int.TryParse(input, out userInputRoll);

                if (!isValidInput || userInputRoll < 1 || userInputRoll > 6)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
                    isValidInput = false;
                }
            } while (!isValidInput);

            return userInputRoll;
        }
    }
}