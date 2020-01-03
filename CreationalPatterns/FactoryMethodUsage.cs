using CreationalPatterns.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns
{
    public static class FactoryMethodUsage
    {
        public static IFastener GetFastener()
        {
            var fastenerFactory = new FastenerFactory();
            var result = fastenerFactory.GetFastener(FastenerType.Bolt);
            var code = result.GetCode(); //!Important part
            return result;
        }
    }
}
