using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module2_HW4_02062023
{
    public class Tiger : Cats
    {
        public Tiger(AnimalsKind kind)
            : base(kind)
        {
            Kind = AnimalsKind.Tiger;
            Weight = 300;
        }
    }
}