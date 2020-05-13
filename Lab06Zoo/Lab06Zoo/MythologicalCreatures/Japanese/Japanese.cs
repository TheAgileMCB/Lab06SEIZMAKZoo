﻿using Lab06Zoo.MythologicalCreatures.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06Zoo.MythologicalCreatures.Japanese
{
    public abstract class Japanese : MythologicalCreature, IEat, IMakeSound
    {
        public virtual bool willMarryMe = false;
    }
}
