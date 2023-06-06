using System;
using Module2_HW4_02062023.Enums;
using Module2_HW4_02062023.Interfaces;

namespace Module2_HW4_02062023.Extentions
{
    public static class Find
    {
        public static Animal[] FindAnimalByFood(
            this IGetAnimals animals,
            MainFood food)
        {
            Animal[] animal = new Animal[0];

            for (int i = 0; i < animals.GetAnimals().Length; i++)
            {
                if (animals.GetAnimals()[i].MainFood == food)
                {
                    Array.Resize(ref animal, animal.Length + 1);
                    animal[animal.Length - 1] = animals.GetAnimals()[i];
                }
            }

            return animal;
        }
    }
}
