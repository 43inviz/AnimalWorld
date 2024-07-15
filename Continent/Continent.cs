using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_AnimalWorld
{
    internal abstract class Continent
    {
        public abstract Carnivore CreateCarnivore();
        public abstract Herbivore CreateHerbivore();
        
    }
}
