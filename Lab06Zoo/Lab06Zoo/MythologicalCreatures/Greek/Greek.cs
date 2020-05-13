
using Lab06Zoo.MythologicalCreatures.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06Zoo.MythologicalCreatures.Greek
{
    public abstract class Greek : MythologicalCreature, IEat, IMakeSound
    {
        public virtual bool bornOfAGod { get; set; } = false;

        public abstract string Eats();

        public abstract string MakeSound();
    }
}
