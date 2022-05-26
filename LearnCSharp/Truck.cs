using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    internal class Truck : IAutomobile
    {
        // properties
        public string LicensePlate
        { get; }

        public double Speed
        { get; set; }

        public int Wheels
        { get; }

        public double Weight
        { get; }

        // constructor
        public Truck(double speed, double weight)
        {
            Speed = speed;
            Weight = weight;
            LicensePlate = Tools.GenerateLicensePlate();
            if (Weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }

        // methods
        public void Honk()
        {
            Console.WriteLine("HONK!");
        }

        public void SpeedUp()
        {
            Speed += 5;
        }

        public void SlowDown()
        {
            Speed -= 5;
        }
    }
}
