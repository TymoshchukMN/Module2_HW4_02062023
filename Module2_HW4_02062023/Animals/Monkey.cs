﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module2_HW4_02062023
{
    public abstract class Monkey : Animal
    {
        public Monkey(AnimalsKind kind)
            : base(kind)
        {
        }
    }
}