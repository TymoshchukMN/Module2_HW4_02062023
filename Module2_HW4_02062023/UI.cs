using System;
using Module2_HW4_02062023.Interfaces;

namespace Module2_HW4_02062023
{
    public class UI : IPrintAviary
    {
        public void PrintAviary(Animal[] animals)
        {
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i]);
            }
        }

        public void PrintAviary(IGetAnimals animals)
        {
            animals.GetAnimals();
        }
    }
}
