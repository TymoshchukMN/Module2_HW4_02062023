using System;

namespace Module2_HW4_02062023
{
    public class Gorilla : Monkey
    {
        public Gorilla(AnimalsKind kind)
            : base(kind)
        {
            Kind = AnimalsKind.Tiger;
            Weight = 120;
            MainFood = Enums.MainFood.Orange;
        }
    }
}