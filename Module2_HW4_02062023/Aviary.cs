using System;
using Module2_HW4_02062023.Interfaces;

namespace Module2_HW4_02062023
{
    public class Aviary : IGetAnimals
    {
        private const int CountAnimals = 15;
        private Animal[] _animals;

        public Aviary()
        {
            int stopRand = Enum.GetNames(typeof(AnimalsKind)).Length;
            _animals = new Animal[CountAnimals];

            Random random = new Random();

            for (int i = 0; i < CountAnimals; i++)
            {
                int randNUm = random.Next(1, stopRand);
                _animals[i] = FillAviary(randNUm);
            }
        }

        public Animal[] Animals
        {
            get { return _animals; }
            set { _animals = value; }
        }

        public Animal[] GetAnimals()
        {
            return _animals;
        }

        private static Animal FillAviary(int randNUm)
        {
            AnimalsKind kind = (AnimalsKind)randNUm;
            Animal animal = null;

            switch (kind)
            {
                case AnimalsKind.Tiger:
                    animal = new Tiger(AnimalsKind.Tiger);
                    break;
                case AnimalsKind.Lion:
                    animal = new Lion(AnimalsKind.Lion);
                    break;
                case AnimalsKind.Сhimpanzee:
                    animal = new Сhimpanzee(AnimalsKind.Сhimpanzee);
                    break;
                case AnimalsKind.Gorilla:
                    animal = new Gorilla(AnimalsKind.Gorilla);
                    break;
            }

            return animal;
        }

       
    }
}