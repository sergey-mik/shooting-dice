using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {
        public override void Play(Player other)
        {
            // Roll the dice for both players
            int myRoll = Roll();
            int otherRoll = other.Roll();

            // Display the roll results
            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");

            try
            {
                // If this player's roll is greater than the other player's roll, they win
                if (myRoll > otherRoll)
                {
                    Console.WriteLine($"{Name} Wins!");
                }
                // If this player's roll is less than the other player's roll, throw an exception
                else if (myRoll < otherRoll)
                {
                    throw new Exception();
                }
                else
                {
                    // If the rolls are equal, the game is a tie
                    Console.WriteLine("It's a tie");
                }
            }
            // Catch the exception thrown when this player loses
            catch
            {
                // Display a message indicating that someone cheated
                Console.WriteLine("Somebody cheated");
            }
        }
    }
}