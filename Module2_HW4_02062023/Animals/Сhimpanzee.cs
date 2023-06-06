using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module2_HW4_02062023
{
    public class Сhimpanzee : Monkey
    {
        public Сhimpanzee(AnimalsKind kind)
            : base(kind)
        {
            Kind = AnimalsKind.Сhimpanzee;
            Weight = 70;
            MainFood = Enums.MainFood.Banana;
        }
    }
}