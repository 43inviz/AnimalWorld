using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_AnimalWorld
{
    internal class AnimalWorld
    {

        public List<Herbivore> Herbivores = new List<Herbivore>();
        public List<Carnivore> Carnivores = new List<Carnivore>();

        public AnimalWorld(Continent continet) 
        {
            Herbivores.Add(continet.CreateHerbivore());
            Carnivores.Add(continet.CreateCarnivore());
            
        }

        public void MealsHerbivores()
        {
            foreach(Herbivore animal in Herbivores)
            {
                Console.WriteLine("Herb eat");
                animal.EatGrass();
            }
        }

        public void MealsCornivores()
        {
           foreach(Carnivore animal in Carnivores)
           {
                int index = 0;
                if(animal.Power > 0)
                {
                    Console.WriteLine("Carn eat");
                    animal.EatHerbivoreAnimal(Herbivores[index]);
                    index++;
                }
           }
        }
    }
}
