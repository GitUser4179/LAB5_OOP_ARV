using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_OOP_ARV.Life
{
    public class Kingdom
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Kingdom(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
