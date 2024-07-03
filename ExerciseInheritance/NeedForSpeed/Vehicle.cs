﻿namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double DefaultFuelConsumption = 1.25;

        public Vehicle(int horsePower,double fuel )
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;  
        }

        public int HorsePower { get; }
        public double Fuel { get; private set; }
        public virtual double FuelConsumption => DefaultFuelConsumption;

        public  void Drive (double kilometers)
        {
            this.Fuel -= this.FuelConsumption * kilometers;
        }
    }
}
