using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_AnimalWorld
{
    internal abstract class Herbivore
    {
        public int Weight { get; set; }

        public bool IsAlife { get; set; }

        public Herbivore() { }

        public Herbivore(int weight) { Weight = weight; IsAlife = true; }

        public abstract void EatGrass();
    }
}
