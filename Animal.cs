using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAnimal
{
    public class Animal
    {
        public IAquaticAnimals AquaticAnimals { get; set; }
        public ILandAnimals LandAnimals { get; set; }
        public DateTime DateDiscoverAnimal { get; set; }
        public Animal()
        {
            
        }
    }
}
