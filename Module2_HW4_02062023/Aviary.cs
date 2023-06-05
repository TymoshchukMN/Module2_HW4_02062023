using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module2_HW4_02062023
{
    public class Aviary
    {

        private Animal[] _animals;

        public Animal [] Animal
        {
            get { return _animals; }
            set { _animals = value; }
        }

    }
}