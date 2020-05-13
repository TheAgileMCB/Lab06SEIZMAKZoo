using Lab06Zoo.MythologicalCreatures.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06Zoo.MythologicalCreatures.Norse
{
    public class Sleipnir : Norse
    {
        public new int numberOfHeads = 1;
        public new bool isFriendly = true;
        public override int numberOfLegs => 8;
        public override int numberOfWings => 0;
        public new bool heraldsRagnarok = false;

        public override string Eats()
        {
            return "Carrots";
        }

        public override string MakeSound()
        {
            return "Neight!";
        }
    }
}
