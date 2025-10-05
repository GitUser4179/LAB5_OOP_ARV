using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_OOP_ARV.Life.Plantae
{
    public class Plant : Kingdom
    {
        protected int PassingAge { get; set; }
        public Plant(string name, int age, int passingAge) : base(name, age)
        {
            PassingAge = passingAge;
        }

        public virtual void Photosynthesize()
        {
            if (Age >= PassingAge)
            {
                Console.WriteLine($"{Name} has withered away and can no longer photosynthesize.");
            }
            else
            {
                Console.WriteLine($"{Name} is absorbing the sunrays and converting them into oxygen.");
            }
        }
        public virtual void Grow(int years)
        {
            Console.WriteLine($"{Name} has grown {Age} years.");
            Age = Age + years;
            if (Age >= PassingAge)
            {
                Console.WriteLine($"{Name} has withered away at age {Age}");
            }
            else
            {
                Console.WriteLine($"{Name} is now {Age} years old.");
            }
        }
    }
}
