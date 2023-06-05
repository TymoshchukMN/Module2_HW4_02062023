using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module2_HW4_02062023
{
    public class Lion : Cats
    {
        public Lion(AnimalsKind kind)
            : base(kind)
        {
            Kind = AnimalsKind.Lion;
            Weight = 350;
        }
    }
}