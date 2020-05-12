using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab06Zoo.MythologicalCreatures
{
    public abstract class MythologicalCreature
    {
        public virtual int numberOfHeads { get; set; } = 1;
        public virtual bool isFriendly { get; set; } = true;
        public abstract int numberOfLegs { get; set; }
        public abstract int numberOfWings { get; set; }

        


    }
}
