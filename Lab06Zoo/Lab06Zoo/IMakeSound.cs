using System;
using System.Collections.Generic;
using System.Text;

namespace Lab06Zoo
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
