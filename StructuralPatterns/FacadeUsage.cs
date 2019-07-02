using StructuralPatterns.Facade;
using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralPatterns
{
    public static class FacadeUsage
    {
        public static List<string> Use()
        {
            var facade = new SharedService();
            var result = facade.GetLocationPermissionsPermutations();
            return result;
        }
    }
}
