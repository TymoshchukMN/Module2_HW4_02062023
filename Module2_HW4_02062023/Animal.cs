using System;
using Module2_HW4_02062023.Interfaces;

namespace Module2_HW4_02062023
{
    public class Animal
    {
        private AnimalsKind _kind;
        private int _weight;

        public Animal(AnimalsKind kind)
        {
            _kind = kind;
        }

        public AnimalsKind Kind
        {
            get
            {
                return _kind;
            }

            protected set
            {
                _kind = value;
            }
        }

        public int Weight
        {
            get
            {
                return _weight;
            }
        }

        public override string ToString()
        {
            return _kind.ToString();
        }
    }
}