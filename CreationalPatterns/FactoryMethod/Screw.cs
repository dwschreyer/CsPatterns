using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.FactoryMethod
{
    public class Screw : IFastener
    {
        public string GetCode()
        {
            return "SCREW001";
        }
    }
}
