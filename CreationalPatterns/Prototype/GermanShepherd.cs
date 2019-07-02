using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.Prototype
{
    public class GermanShepherd : Dog
    {
        public override Dog Clone()
        {
            return (Dog)this.MemberwiseClone();
        }
    }
}
