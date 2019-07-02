using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.Prototype
{
    public class Huskey : Dog
    {
        public override Dog Clone()
        {
            return (Dog)this.MemberwiseClone();
        }
    }
}
