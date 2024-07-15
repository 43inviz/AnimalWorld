using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_AnimalWorld
{
    internal class NorthAmerica:Continent
    {
        public NorthAmerica() { }

        public override Herbivore CreateHerbivore()
        {
            return new Bison(100);
        }

        public override Carnivore CreateCarnivore()
        {
            return new Wolf(100);
        }
    }
}
