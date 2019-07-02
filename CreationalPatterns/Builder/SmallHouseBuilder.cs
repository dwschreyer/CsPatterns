using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.Builder
{
    public class SmallHouseBuilder : IHouseBuilder
    {
        public int BedroomCount { get; set; }
        public bool IsForSale { get; set; }

        public House GetResult()
        {
            if(BedroomCount == 0)
            {
                throw new InvalidOperationException("The house needs some bedrooms and bathrooms.");
            }

            if (BedroomCount > 2)
            {
                return null;
            }

            return new House(BedroomCount, 1, 0, IsForSale);
        }
    }
}
