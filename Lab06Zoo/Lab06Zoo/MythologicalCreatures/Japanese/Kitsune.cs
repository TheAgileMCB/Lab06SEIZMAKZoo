using Lab06Zoo.MythologicalCreatures.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06Zoo.MythologicalCreatures.Japanese
{
    public class Kitsune : Japanese, ICanOutrun
    {
        public new int numberOfHeads = 1;
        public new bool isFriendly = true;
        public override int numberOfLegs => 4;
        public override int numberOfWings => 0;
        public new bool willMarryMe = true;


        public override string Eats()
        {
            return "berries";
        }

        public override string MakeSound()
        {
            return "Yip!";
        }

        public bool CanOutrun() => false;
    }
}
