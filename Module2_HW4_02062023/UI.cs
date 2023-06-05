using System;
using Module2_HW4_02062023.Interfaces;

namespace Module2_HW4_02062023
{
    public class UI : IPrintAviary
    {
        public void PrintAviary(IGetAnimals animals)
        {
            for (int i = 0; i < animals.GetAnimals().Length; i++)
            {
                Console.WriteLine(animals.GetAnimals()[i]);
            }
        }
    }
}
