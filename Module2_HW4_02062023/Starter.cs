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
            UI.PrintAviary(aviary, "Just created aviary");

            // сортировка по весу
            ((ISortByWeight)aviary).SortByWeight(aviary);
            UI.PrintAviary(aviary, "Sorted by weight");

            // сотртировка по типу (названию)
            Array.Sort(aviary.GetAnimals());
            UI.PrintAviary(aviary, "Sorted by name");

            UI.PrintGroupedAnimals((ICountedAnimals)aviary);

            // поиск и печать животного по типу еды
            UI.PrintAviary(
                Find.FindAnimalByFood(aviary, MainFood.Meat));
        }
    }
}
