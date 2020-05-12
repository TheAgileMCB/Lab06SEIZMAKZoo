using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Lab06Zoo
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
