using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.FactoryMethod
{
    public class FastenerFactory
    {
        public IFastener GetFastener(FastenerType fastenerType)
        {
            switch (fastenerType)
            {
                case FastenerType.Bolt:
                    return new Bolt();
                case FastenerType.Screw:
                    return new Screw();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
