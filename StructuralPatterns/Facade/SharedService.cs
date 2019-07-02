using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructuralPatterns.Facade
{
    public class SharedService
    {
        private readonly TenantProcessor _tenantProcessor = new TenantProcessor();
        private readonly UserProcessor _userProcessor = new UserProcessor();

        public List<string> GetLocationPermissionsPermutations()
        {
            var locations = _tenantProcessor.GetLocations();
            var permissions = _userProcessor.GetAllPermissions();

            var query = from l in locations
                         from p in permissions
                         select $"{l} {p}";

            var result = query.ToList();
            return result;
        }
    }
}
