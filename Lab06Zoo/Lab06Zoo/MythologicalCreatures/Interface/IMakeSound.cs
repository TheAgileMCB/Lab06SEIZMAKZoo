using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06Zoo.MythologicalCreatures.Interface
{
    interface IMakeSound
    {
        abstract string MakeSound()
        {
            string sound = "";
            return sound;
        }  
    }
}
