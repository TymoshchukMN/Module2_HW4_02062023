using System;
using Module2_HW4_02062023.Interfaces;

namespace Module2_HW4_02062023
{
    public class UI
    {
        public static void PrintAviary(IGetAnimals animals)
        {
            Console.WriteLine("number of different types of " +
                "creatures in the section");
            for (int i = 0; i < animals.GetAnimals().Length; i++)
            {
                Console.WriteLine(animals.GetAnimals()[i]);
            }
        }

        public static void PrintSortedAnimals(ICountedAnimals countedAnimals)
        {
            Console.WriteLine("number of different types of creatures " +
                "in the section");
            for (int i = 0; i < countedAnimals.CountAnimals().Length; i++)
            {
                Console.Write(countedAnimals.CountAnimals()[i].Split(':')[0]);
                Console.WriteLine($"" +
                    $"\t{countedAnimals.CountAnimals()[i].Split(':')[1]}");
            }
        }

        public static void PrintAviary(Animal[] animals)
        {
            Console.WriteLine("number of different types of creatures " +
                "in the section");
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i]);
            }
        }
    }
}
