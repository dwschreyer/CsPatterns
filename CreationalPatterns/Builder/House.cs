using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.Builder
{
    public class House
    {
        public House(int bedroomCount, int bathroomCount, int garageCount, bool isForSale)
        {
            BedroomCount = bedroomCount;
            BathroomCount = bathroomCount;
            GarageCount = garageCount;
            IsForSale = isForSale;
        }

        public int BedroomCount { get; set; }
        public int BathroomCount { get; set; }
        public int GarageCount { get; set; }
        public bool IsForSale { get; set; }
    }
}
