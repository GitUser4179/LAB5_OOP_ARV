using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_OOP_ARV.Life.Animalia.Mammals
{
    public class Elephant : Mammal
    {
        public string MemoryCapacity { get; set; } // "below-average, average, above-average, excellent"
        public Elephant(string name, int age, string sound, bool tamed, string family, string memoryCapacity) : base(name, age, sound, tamed, family)
        {
            Name = name;
            Age = age;
            Sound = sound;
            Tamed = tamed;
            Family = family;
            MemoryCapacity = memoryCapacity;
        }

        public  override void GetInfo()
        {
            Console.WriteLine($"The {BloodType} Mammal by the name of {Name} is of the {Family} species. {Name}'s age is {Age} and makes the {Sound} sound when using their snout to communicate. {Name} is {(Tamed ? "tame" : "wild")} and their memory capacity is {MemoryCapacity}");
        }

        public override void Pet()
        {
            if (Tamed)
            {
                Console.WriteLine($"You gently pet {Name}, it feels tough and rough to the touch.");
            }
            else
            {
                Console.WriteLine($"You don't think attempting to pet a wild elephant is very safe.");
            }
        }
        
        public void SprayWater()
        {
            if (Tamed)
            {
                Console.WriteLine($"{Name} loads its trunk with water and sprays you! You get soaked.");
            }
            else
            {
                Console.WriteLine($"{Name} loads its trunk with water and gives itself a shower to cool down.");
            }
        }
    }
}
