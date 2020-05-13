using Lab06Zoo.MythologicalCreatures.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06Zoo.MythologicalCreatures.Greek
{
    public class Chimera : Greek, ICanOutrun
    {
        public new int numberOfHeads = 3;
        public new bool isFriendly = false;
        public override int numberOfLegs => 4;
        public override int numberOfWings => 0;
        public new bool bornOfAGod = false;

        public override string Eats()
        {
            return "Humans";
        }

        public override string MakeSound()
        {
            return "Roar!";
        }

        public bool ICanOutRun() => false;
    }
}
