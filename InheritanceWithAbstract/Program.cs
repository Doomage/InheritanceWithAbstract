using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceWithAbstract
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Animal> AnimalList = new List<Animal>();

            AnimalList.Add(new Dog("Pug"));
            AnimalList.Add(new Cat("Ragdoll"));
            AnimalList.Add(new Dog("Labrador"));
            AnimalList.Add(new Snake("Cobra"));

            foreach (var animal in AnimalList)
            {
                animal.Eat();
                animal.MakeNoise();
                if (animal is IWalk)
                {
                    GoForAWalk((IWalk)animal);
                }
                else
                {
                    Console.WriteLine("Snakes cant Walk");
                }
            }
            Console.ReadKey();
        }

        static void GoForAWalk(IWalk WalkingAnimal)
        {
            WalkingAnimal.Walking();
        }
    }
}
