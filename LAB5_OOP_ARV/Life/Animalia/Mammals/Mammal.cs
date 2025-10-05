using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_OOP_ARV.Life.Animalia.Mammals
{
    public class Mammal : Animal
    {
        protected string BloodType { get; set; }
        public Mammal(string name, int age, string sound, bool tamed, string family) : base(name, age, sound, tamed, family)
        {
            BloodType = "Warm-blooded";
        }

        public override void GetInfo()
        {
            Console.WriteLine($"The animal {Family} has the name {Name} and is {Age} years old. They are a {BloodType} and make the sound {Sound} when they attempt to communicate.");
        }
    }
}
