using Lab06Zoo.MythologicalCreatures.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06Zoo.MythologicalCreatures.Greek
{
    public class Pegasus : Greek, ICanRide, ICanOutrun
    {
        public new int numberOfHeads = 1;
        public new bool isFriendly = true;
        public override int numberOfLegs => 4;
        public override int numberOfWings => 2;
        public new bool bornOfAGod = true;

        public override string Eats()
        {
            return "Carrots";
        }

        public override string MakeSound()
        {
            return "Neigh!";
        }

        public bool CanRide() => true;

        public bool CanOutrun() => false;

    }
}
