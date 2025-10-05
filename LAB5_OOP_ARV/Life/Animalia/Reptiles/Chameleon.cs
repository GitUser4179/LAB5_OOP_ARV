using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_OOP_ARV.Life.Animalia.Reptiles
{
    public class Chameleon : Reptile
    {
        public string CurrentColor { get; set; }
        public Chameleon(string name, int age, string sound, bool tamed, string family, string currentColor) : base(name, age, sound, tamed, family)
        {
            CurrentColor = currentColor;
        }

        public override void Pet()
        {
            if (Tamed)
            {
                Console.WriteLine($"You gently pet {Name}, they feel scaly and cool to the touch.");
            }
            else
            {
                Console.WriteLine($"You try to pet {Name}, the reptile smoothly slithers away from your reach of grasp.");
            }
        }
        public void ChangeColor(string newColor)
        {
            Console.WriteLine($"{Name} changes its color to {newColor} in order to blend in with the environment.");
        }

        public void ReactToTemperature(int temperature)
        {
            if (temperature < 20)
            {
                Console.WriteLine($"{Name} basks in the sun to warm up.");
                ChangeColor("dark brown");
            }
            else if (temperature >= 40)
            {
                Console.WriteLine($"{Name} seeks shade and cools down by staying still.");
                ChangeColor("bright green");
            }
            else
            {
                Console.WriteLine($"{Name} is comfortable with the current temperature.");
            }
        }
    }
}
