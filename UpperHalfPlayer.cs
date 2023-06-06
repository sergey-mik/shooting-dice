using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {
        public override int Roll()
        {
            int upperHalf = (DiceSize / 2) + 1;
            int half = DiceSize / 2;
            // Return a random number between 1 and DiceSize
            return new Random().Next(half) + upperHalf;
        }
    }
}