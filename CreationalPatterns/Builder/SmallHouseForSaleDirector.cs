using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.Builder
{
    public class SmallHouseForSaleDirector
    {
        private readonly IHouseBuilder _houseBuilder;

        public SmallHouseForSaleDirector(IHouseBuilder houseBuilder)
        {
            _houseBuilder = houseBuilder;
        }

        public void Construct()
        {
            _houseBuilder.BedroomCount = 2;
            _houseBuilder.IsForSale = true;
        }
    }
}
