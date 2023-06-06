using System;
using Module2_HW4_02062023.Enums;
using Module2_HW4_02062023.Extentions;
using Module2_HW4_02062023.Interfaces;

namespace Module2_HW4_02062023
{
    internal class Starter
    {
        public static void Run()
        {
            IGetAnimals aviary = new Aviary();
            ICountedAnimals countedAnimals = (ICountedAnimals)aviary;
            ISortByWeight sorted = (ISortByWeight)aviary;

            UI.PrintAviary(aviary, "Just created aviary");

            // сортировка по весу
            sorted.SortByWeight(aviary);
            UI.PrintAviary(aviary, "Sorted by weight");

            // сотртировка по типу (названию)
            Array.Sort(aviary.GetAnimals());
            UI.PrintAviary(aviary, "Sorted by name");

            UI.PrintGroupedAnimals(countedAnimals);

            // поиск и печать животного по типу еды
            UI.PrintAviary(
                Find.FindAnimalByFood(aviary, MainFood.Meat));
        }
    }
}
