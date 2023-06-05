using System;
using Module2_HW4_02062023.Interfaces;

namespace Module2_HW4_02062023
{
    internal class Starter
    {
        public static void Run()
        {
            IGetAnimals aviary = new Aviary();
            ICountedAnimals countedAnimals = (ICountedAnimals)aviary;

            UI.PrintAviary(aviary);
            Console.WriteLine();
            UI.PrintSortedAnimals(countedAnimals);



        }
    }
}
