using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module2_HW4_02062023
{
    public class Animal
    {
        private AnimalsKind _kind;
        private int _weight;

        public Animal(AnimalsKind kind, int weight)
        {
            _kind = kind;
            _weight = weight;
        }

        public AnimalsKind Kind
        {
            get
            {
                return _kind;
            }
        }

        public int Weight
        {
            get
            {
                return _weight;
            }
        }
    }
}