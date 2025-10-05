using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace LAB5_OOP_ARV.Life.Plantae
{
    public class Redwood : Plant
    {
        public double HeightInMeters { get; set; }

        public Redwood(string name, int age, int passingAge, double initialHeight) : base(name, age, passingAge)
        {
            HeightInMeters = initialHeight;
        }

        public override void Grow(int years)
        {
            base.Grow(years);

            if (Age < PassingAge)
            {
                double heightGrowth = years * 0.5; // Example: grows 0.5 meters per year
                HeightInMeters += heightGrowth;
                Console.WriteLine($"{Name} has grown taller and is now {HeightInMeters:F1} meters tall.");
            }
            else
            {
                Console.WriteLine($"{Name} has stopped growing due to age.");
            }
        }
    }
}
