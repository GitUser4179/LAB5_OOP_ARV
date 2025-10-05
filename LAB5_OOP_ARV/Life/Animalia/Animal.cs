using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB5_OOP_ARV.Life;

namespace LAB5_OOP_ARV.Life.Animalia
{
    public class Animal : Kingdom
    {
        protected string Sound { get; set; }
        public bool Tamed { get; set; }
        protected string Family { get; set; }

        public Animal(string name, int age, string sound, bool tamed, string family) : base(name, age)
        {
            Sound = sound;
            Tamed = tamed;
            Family = family;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name}: *{Sound}*");
        }

        public virtual void Pet()
        {
            if (Tamed)
            {
                Console.WriteLine($"You gently pet {Name}, it seems as they liked it.");
            }
            else
            {
                Console.WriteLine($"You try to pet {Name}, they move away from you before you can reach.");
            }
        }       
        public virtual void GetInfo()
        {
            Console.WriteLine($"The animal {Family} has the name {Name} and is {Age} years old. They make the sound *{Sound}* when they speak.");
        }
    }
}
