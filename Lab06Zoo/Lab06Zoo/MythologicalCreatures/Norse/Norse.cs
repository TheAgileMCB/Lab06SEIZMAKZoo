using Lab06Zoo.MythologicalCreatures.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06Zoo.MythologicalCreatures.Norse
{
    public abstract class Norse : MythologicalCreature, IEat, IMakeSound
    {
        public virtual bool heraldsRagnarok = false;

        public abstract string Eats();

        public abstract string MakeSound();
      
    }

    

}
