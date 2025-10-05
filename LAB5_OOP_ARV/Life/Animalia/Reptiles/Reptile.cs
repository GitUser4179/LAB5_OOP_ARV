using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LAB5_OOP_ARV.Life.Animalia.Reptiles
{
    public class Reptile : Animal
    {
        protected string BloodType { get; set; }
        public Reptile(string name, int age, string sound, bool tamed, string family) : base(name, age, sound, tamed, family)
        {
            BloodType = "Cold-blooded";
        }

        public override void GetInfo()
        {
            Console.WriteLine($"The {BloodType} {Name} is of the {Family} family. {Name}'s age is {Age} and makes the {Sound} sound when trying to communicate. {Name} is {(Tamed ? "tame" : "wild")}.");
        }

    }

}
