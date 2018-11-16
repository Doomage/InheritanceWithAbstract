# InheritanceWithAbstract
Ναφτιάξετε:
•1 abstract class Animal.
•1 interface IWalk
•2 μεθόδουςστηνAnimal: MakeNoise(), Eat()
•2παραμέτρουςστηνAnimal, που να παίρνουν τιμή στον constructor:string Name, AnimalType TypeOfAnimal
•1 μέθοδο στο IWalk: Walking()
•3 classesπαιδιάτηςAnimal: Dog, Cat, Snake

Να δημιουργήσετε στη Mainένα ζώο από κάθε τύπο και να το βάλετε σε μία λίσταList<Animal> AnimalsList.
  
•2 αντικείμεναDog : Pug, Labrador
•1 αντικείμενοCat: Ragdoll
•1 αντικείμενοSnake: Cobra

Να φτιάξετε μία μέθοδο GoForAWalk(IWalk WalkingAnimal), που να καλεί τη μέθοδο Walking() από κάθε αντικείμενο που παίρνειΝα τρέξετε τις μεθόδους των ζώων σε μία foreach

Αν το Animal υλοποιεί την IWalk vα καλέσετε την GoForAWalk()
