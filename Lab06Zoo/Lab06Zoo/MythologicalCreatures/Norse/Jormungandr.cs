using Lab06Zoo.MythologicalCreatures.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06Zoo.MythologicalCreatures.Norse
{
    public class Jormungandr : Norse, ICanRide
    {
        public new int numberOfHeads = 1;
        public new bool isFriendly = false;
        public override int numberOfLegs => 0;
        public override int numberOfWings => 0;
        public new bool heraldsRagnarok = true;

        public override string Eats()
        {
            return "Gods";
        }

        public override string MakeSound()
        {
            return "Ssssss!";
        }

        public bool ICanRide() => false;
    }
}
