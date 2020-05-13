using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Lab06Zoo.MythologicalCreatures.Interface
{
    public interface IEat
    {
        public abstract string Eats()
        {
            string eat = "";
            return eat;
        }
    }
}
