using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralPatterns.Facade
{
    public class UserProcessor
    {
        public List<string> GetAllPermissions()
        {
            var result = new List<string>()
            {
                "Admin",
                "User",
                "Restricted"
            };

            return result;
        }
    }
}
