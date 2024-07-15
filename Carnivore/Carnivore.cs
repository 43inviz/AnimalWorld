using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_AnimalWorld
{
    internal abstract class Carnivore
    {
        public int Power { get; set; }
        public Carnivore() { }
        public Carnivore(int power) { Power = power; }
        public abstract void EatHerbivoreAnimal(Herbivore animal);


    }
}
