using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_AnimalWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Africa afc = new Africa();
            AnimalWorld aw = new AnimalWorld(afc);

            aw.MealsHerbivores();
            aw.MealsCornivores();

            Console.ReadLine();
        }
    }
}
