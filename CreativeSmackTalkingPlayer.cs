using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        public List<string> Taunts { get; set; }

        private static List<string> DefaultTaunts = new List<string>
    {
        "Is that all you got?",
        "Better luck next time!",
        "You're way out of your league!"
    };

        public CreativeSmackTalkingPlayer() : this(DefaultTaunts) { }

        public CreativeSmackTalkingPlayer(List<string> taunts)
        {
            Taunts = taunts;
        }

        public override int Roll()
        {
            Random random = new Random();
            int index = random.Next(Taunts.Count);
            string randomTaunt = Taunts[index];
            Console.WriteLine($"{Name} screams: {randomTaunt}");
            return base.Roll();
        }
    }
}