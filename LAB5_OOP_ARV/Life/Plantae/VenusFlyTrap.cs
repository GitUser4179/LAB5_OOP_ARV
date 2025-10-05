using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_OOP_ARV.Life.Plantae
{
    public class VenusFlytrap : Plant
    {
        public bool IsTrapOpen { get; set; }
        public VenusFlytrap(string name, int age, int passingAge) : base(name, age, passingAge)
        {
            IsTrapOpen = true;
        }

        public void SnapTrap()
        {
            if (IsTrapOpen && Age < PassingAge)
            {
                Console.WriteLine($"{Name} snaps its trap shut on an insect!");
                IsTrapOpen = false;
            }
            else if (!IsTrapOpen)
            {
                Console.WriteLine($"{Name}'s trap is already closed.");
            }
            else
            {
                Console.WriteLine($"{Name} is too old to trap insects.");
            }
        }

        public void ReopenTrap()
        {
            IsTrapOpen = true;
            Console.WriteLine($"{Name} reopens its trap.");
        }
    }

}
