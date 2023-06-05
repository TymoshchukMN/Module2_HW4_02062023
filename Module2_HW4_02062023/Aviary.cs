using System;
using Module2_HW4_02062023.Interfaces;

namespace Module2_HW4_02062023
{
    public class Aviary : IGetAnimals, ICountedAnimals
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

        string[] ICountedAnimals.CountAnimals()
        {
            string[] groupedAnimals = new string[0];
            int n = _animals.Length;

            for (int i = 0; i < n; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (_animals[i].ToString() == _animals[j].ToString())
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    Array.Resize(ref groupedAnimals, groupedAnimals.Length + 1);
                    groupedAnimals[groupedAnimals.Length - 1]
                        = $"{_animals[i]}";
                }
            }

            for (int i = 0; i < groupedAnimals.Length; i++)
            {
                int countCpecificGifts = 0;
                for (int j = 0; j < _animals.Length; j++)
                {
                    string giftForCompaire = groupedAnimals[i];
                    if (giftForCompaire == _animals[j].ToString())
                    {
                        ++countCpecificGifts;
                    }
                }

                //string strWeifhtOneGift = groupedAnimals[i].Split(':')[0];
                //string gift = groupedAnimals[i].Split(':')[1];

                groupedAnimals[i] = $"{countCpecificGifts}:" +
                    $"{groupedAnimals[i]}";
            }

            Array.Sort(groupedAnimals);
            Array.Reverse(groupedAnimals);

            return groupedAnimals;
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