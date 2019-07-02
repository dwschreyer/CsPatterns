using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralPatterns.Facade
{
    public class TenantProcessor
    {
        public List<string> GetLocations()
        {
            var result = new List<string>()
            {
                "Auckland",
                "Wellington",
                "Sydney",
                "Johannesburg"
            };

            return result;
        }
    }
}
