using System;
using Module2_HW4_02062023.Enums;

namespace Module2_HW4_02062023
{
    public class Animal
    {
        private AnimalsKind _kind;
        private MainFood _mainFood;
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

        public MainFood MainFood
        {
            get { return _mainFood; }
            set { _mainFood = value; }
        }

        public int Weight
        {
            get
            {
                return _weight;
            }

            set
            {
                _weight = value;
            }
        }

        public override string ToString()
        {
            return _kind.ToString();
        }
    }
}