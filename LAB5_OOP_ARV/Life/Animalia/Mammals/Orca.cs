using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_OOP_ARV.Life.Animalia.Mammals
{
    public class Orca : Mammal
    {
        public string HuntingTechnique { get; set; } // "wave washing seals off ice floes", "carousel feeding", "beach hunting", "fish herding"
 
        public Orca(string name, int age, string sound, bool tamed, string family, string huntingTechnique) : base(name, age, sound, tamed, family)
        {
            HuntingTechnique = huntingTechnique;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"The {BloodType} Mammal by the name of {Name} is of the {Family} family. {Name}'s age is {Age} and makes the {Sound} sound when trying to echolocate & communicate. {Name} is {(Tamed ? "tame" : "wild")} and their favourite hunting technique is {HuntingTechnique}");
        }

        public override void Pet()
        {
            if (Tamed)
            {
                Console.WriteLine($"You gently pet {Name}, it feels smooth and rubbery similar to a hard-boiled egg.");
            }
            else
            {
                Console.WriteLine($"You try to pet {Name}, the orca is not in your reach and swims away.");
            }
        }

        public void Echolocate()
        {
            Console.WriteLine($"{Name} emits a series of {Sound} to scout its surroundings.");
        }
    }
}
