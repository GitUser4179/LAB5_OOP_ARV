using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LAB5_OOP_ARV.Life.Animalia.Reptiles
{
    public class Crocodile : Reptile
    {
        public double JawBiteForce { get; set; }
        public Crocodile(string name, int age, string sound, bool tamed, string family, double jawBiteForce) : base(name, age, sound, tamed, family)
        {
            JawBiteForce = jawBiteForce;
        }

        public override void Pet()
        {
            if (Tamed)
            {
                Console.WriteLine($"You worry whether you should attempt to pet a crocodile. Even if it is tame it is still dangerous.");
            }
            else
            {
                Console.WriteLine($"Are you seriously trying to pet a crocodile?");
            }
        }

        public void DeathRoll()
        {
            Console.WriteLine($"{Name} spots a predator in the waters and perform's a deathroll with the jaw bite force of {JawBiteForce} PSI. Poor prey.");
        }
    }
}
