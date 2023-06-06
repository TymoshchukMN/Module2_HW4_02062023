using System;
using Module2_HW4_02062023.Interfaces;

namespace Module2_HW4_02062023
{
    public class UI
    {
        public static void PrintAviary(IGetAnimals animals, string message)
        {
            ChangeColor($"{message}\n", ConsoleColor.Green);

            for (int i = 0; i < animals.GetAnimals().Length; i++)
            {
                Console.WriteLine(animals.GetAnimals()[i]);
            }

            Console.WriteLine();
        }

        public static void PrintGroupedAnimals(ICountedAnimals countedAnimals)
        {
            ChangeColor(
                "number of different types of creatures " +
                "in the section\n",ConsoleColor.Cyan);

            for (int i = 0; i < countedAnimals.CountAnimals().Length; i++)
            {
                Console.Write(countedAnimals.CountAnimals()[i].Split(':')[0]);
                Console.WriteLine($"" +
                    $"\t{countedAnimals.CountAnimals()[i].Split(':')[1]}");
            }

            Console.WriteLine();
        }

        public static void PrintAviary(Animal[] animals)
        {
            ChangeColor(
                $"Animals that eat {animals[0].MainFood}:\n", ConsoleColor.Blue);

            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i]);
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Chenge color item.
        /// </summary>
        /// <param name="str">
        /// str for print.
        /// </param>
        /// <param name="newColor">
        /// new color.
        /// </param>
        private static void ChangeColor(string str, ConsoleColor newColor)
        {
            ConsoleColor def = Console.ForegroundColor;
            Console.ForegroundColor = newColor;
            Console.Write(str);
            Console.ForegroundColor = def;
        }
    }
}
