using CreationalPatterns.Builder;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns
{
    public static class BuilderUsage
    {
        public static House BuildAHouse()
        {
            var houseBuilder = new SmallHouseBuilder();
            var houseDirector = new SmallHouseForSaleDirector(houseBuilder);

            houseDirector.Construct();
            var result = houseBuilder.GetResult();
            return result;
        }
    }
}
