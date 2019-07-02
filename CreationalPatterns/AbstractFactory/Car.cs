using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns.AbstractFactory
{
    public class Car : IVehicle
    {
        private bool _isMoving;

        public void Start()
        {
            _isMoving = true;
        }

        public void Stop()
        {
            _isMoving = false;
        }

        public int PassengerCapacity { get; set; }
    }
}
