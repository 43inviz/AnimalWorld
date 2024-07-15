using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_AnimalWorld
{
    internal class Wolf:Carnivore
    {
        public Wolf() { }
        public Wolf(int power):base (power) { } 

        public override void EatHerbivoreAnimal(Herbivore animal)
        {
            if (animal.Weight < this.Power)
            {
                this.Power += 10;
            }
            else
            {
                this.Power -= 10; 
            }

            animal.IsAlife = false;
        }
    }
}
