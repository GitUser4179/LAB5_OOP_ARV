using LAB5_OOP_ARV.Life;
using LAB5_OOP_ARV.Life.Plantae;
using LAB5_OOP_ARV.Life.Animalia;
using LAB5_OOP_ARV.Life.Animalia.Mammals;
using LAB5_OOP_ARV.Life.Animalia.Reptiles;

namespace LAB5_OOP_ARV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Instructions
                Animal (requires string name, int age, string sound, bool tamed, string species)
                    Mammal
                        Orca (requires: string memoryCapacity)
                        Elephant (requires: string memoryCapacity)
                    Reptile
                        Crocodile (requires: int biteForceInPSI)
                        Chameleon (requires: string currentColor)
                Plant (requires string name, int age, int passingAge)
                    Redwood (requires: double heightInMeters)
                    VenusFlytrap (requires: bool isTrapOpen)
            Notes
                You can create custom animals and plants that inherit from the base classes however they will not have unique behaviours like the ones I've created.
                A property being protected means that it should not be changed once it's been set, if it's public it should be open to change.
             */

            Console.WriteLine();
            Orca orca = new Orca("Billy", 22, "high-pitched whistles", false, "Orcinus", "cooperative hunting in pods");
            orca.GetInfo();
            orca.Pet();
            orca.Tamed = true;
            orca.Pet();
            orca.MakeSound();
            orca.Echolocate();

            Console.WriteLine();
            Elephant elephant = new Elephant("Big-snout", 41, "hooooonk", false, "Elephantidae", "above-average");
            elephant.GetInfo();
            elephant.Pet();
            elephant.MakeSound();
            elephant.SprayWater();

            Console.WriteLine();
            Chameleon chameleon = new Chameleon("Cammy", 5, "hiss", true, "Chamaeleonidae", "green");
            chameleon.GetInfo();
            chameleon.Pet();
            chameleon.MakeSound();
            chameleon.ReactToTemperature(15);
            chameleon.ReactToTemperature(45);
            chameleon.ReactToTemperature(25);

            Console.WriteLine();
            Crocodile crocodile = new Crocodile("Snapper", 12, "growl", false, "Crocodylidae", 3700);
            chameleon.GetInfo();
            chameleon.Pet();
            chameleon.MakeSound();
            crocodile.DeathRoll();

            Console.WriteLine();
            Redwood redwood = new Redwood("Tallie", 50, 5000, 20.0);
            redwood.Photosynthesize();
            redwood.Grow(100);
            redwood.Grow(4900);
            redwood.Grow(1);
            redwood.Photosynthesize();

            Console.WriteLine();
            VenusFlytrap venusFlytrap = new VenusFlytrap("Venus", 3, 10);
            venusFlytrap.Photosynthesize();
            venusFlytrap.SnapTrap();
            venusFlytrap.ReopenTrap();
            venusFlytrap.Grow(5);
        }
    }
}
