using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.Prototype
{
    public abstract class Dog
    {
        public string Name { get; set; }

        public abstract Dog Clone();
    }
}
