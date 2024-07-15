using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_AnimalWorld
{
    internal class Africa:Continent
    {
        public Africa() { }

        public override Carnivore CreateCarnivore()
        {
            return new Lion(100);
        }

        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest(100);
        }
    }
}
