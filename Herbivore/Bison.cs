using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_AnimalWorld
{
    internal class Bison:Herbivore
    {
        public Bison() { }
        public Bison(int weight) { this.Weight = weight; }

        public override void EatGrass()
        {
            this.Weight+=10;
        }
    }
}
