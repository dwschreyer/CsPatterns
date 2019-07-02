using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.Builder
{
    public interface IHouseBuilder
    {
        int BedroomCount { get; set; }
        bool IsForSale { get; set; }

        House GetResult();
    }
}
