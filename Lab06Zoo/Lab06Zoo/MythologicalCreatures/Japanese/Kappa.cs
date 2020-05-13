using Lab06Zoo.MythologicalCreatures.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06Zoo.MythologicalCreatures.Japanese
{
    public class Kappa : Japanese, ICanRide, ICanOutrun
    {
        public new int numberOfHeads = 1;
        public new bool isFriendly = false;
        public override int numberOfLegs => 2;
        public override int numberOfWings => 0;
        public new bool willMarryMe = false;


        public override string Eats()
        {
            return "cucumbers";
        }

        public override string MakeSound()
        {
            return "???";
        }

        public bool ICanRide() => false;

        public bool ICanOutrun() => true;
    }
}
