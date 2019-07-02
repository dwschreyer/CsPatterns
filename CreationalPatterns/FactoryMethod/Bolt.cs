using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.FactoryMethod
{
    public class Bolt : IFastener
    {
        public string GetCode()
        {
            return "BOLT001";
        }
    }
}
