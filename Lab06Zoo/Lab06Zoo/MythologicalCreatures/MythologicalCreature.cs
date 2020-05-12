using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06Zoo.MythologicalCreatures
{
    public abstract class MythologicalCreature
    {
        public virtual int numberOfHeads { get; set; } = 1;
        public virtual bool hasWings { get; set; } = false;
        public abstract int numberOfLegs { get; set; }

        


    }
}
