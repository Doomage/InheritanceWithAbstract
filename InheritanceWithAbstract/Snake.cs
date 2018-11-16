using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWithAbstract
{
    class Snake:Animal
    {
        public AnimalType Typeofanimal = AnimalType.Snake;

        public Snake(string name)
        {
            Name = name;  
        }

        public override void Eat()
        {
            Console.WriteLine($"The {Typeofanimal} with name {Name} Eating");
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"The {Typeofanimal} with name {Name} making noise");
        }
    }
}
