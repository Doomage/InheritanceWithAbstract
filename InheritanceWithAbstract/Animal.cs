using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWithAbstract
{
    public abstract class Animal
    {

        public enum AnimalType {Cat,Dog,Snake};
        public AnimalType Typeofanimal;
        public string Name;
        public abstract void MakeNoise();
        public abstract void Eat();
    }
}
