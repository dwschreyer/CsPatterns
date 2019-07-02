using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.AbstractFactory
{
    public interface IVehicleFactory
    {
        IVehicle CreateVehicle();
    }
}
