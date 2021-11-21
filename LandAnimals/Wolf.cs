using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAnimal.LandAnimals
{
    public class Wolf : ILandAnimals
    {
        public int Weight { get; set; }
        public string Says { get; set; }
        public Wolf()
        {
            Weight = 80;
            Says = "Wolf say Wooof";
        }
        public void Walk()
        {
            Console.WriteLine("Wolf walk and "+Says);
        }
    }
}
