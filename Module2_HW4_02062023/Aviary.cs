using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module2_HW4_02062023
{
    public class Aviary
    {
        private const int CountAnimals = 16;
        private Animal[] _animals;

        public Animal [] Animal
        {
            get { return _animals; }
            set { _animals = value; }
        }

        const int StartRand = 1;
        const int StopRand = 8;

        public Aviary()
        {
            _animals = new Animal[CountAnimals];
            Random random = new Random();

            // наполнение коробки подарками в случайном порядке
            for (int i = 0; i < CountAnimals; i++)
            {
                int randNUm = random.Next(StartRand, StopRand);
                _animals[i] = FillAviary(randNUm);
            }
        }

        private static Animal FillAviary(int randNUm)
        {
            AnimalsKind kind = (AnimalsKind)randNUm;
            Animal animal;

            switch (kind)
            {
                case AnimalsKind.Tiger:
                    animal = new Tiger();
                    break;
                case AnimalsKind.Lion:
                    break;
                case AnimalsKind.Сhimpanzee:
                    break;
                case AnimalsKind.Gorilla:
                    break;
                default:
                    break;
            }

            return animal;
        }
    }
}