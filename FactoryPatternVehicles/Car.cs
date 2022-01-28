﻿using System;
namespace FactoryPatternVehicles
{
    public class Car : IVehicle
    {
        public Car()
        {
        }

        public void Drive()
        {
            Console.WriteLine("The Car is driving at a safe pace. Oh boy!");
        }
    }
}
