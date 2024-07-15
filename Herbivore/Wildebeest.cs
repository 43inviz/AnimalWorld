using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_AnimalWorld
{
    internal class Wildebeest:Herbivore
    {
        public Wildebeest() { }
        public Wildebeest(int weight)  { this.Weight = weight; }

        public override void EatGrass()
        {
            this.Weight += 10;
        }




    }
}
