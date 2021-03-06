﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWithAbstract
{
    class Cat:Animal,IWalk
    {
        public AnimalType Typeofanimal = AnimalType.Cat;
        public Cat(string name)
        {
            Name = name;
        }

        public override void Eat()
        {
            Console.WriteLine($"The {Typeofanimal} with name {Name} Eating");
        }

        public override void MakeNoise()
        {
            Console.WriteLine($"The {Typeofanimal} with name {Name} Making noise");
        }

        public void Walking()
        {
            Console.WriteLine($"The {Typeofanimal} with name {Name} walking");
        }
    }
}
