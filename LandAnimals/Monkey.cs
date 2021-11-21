using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAnimal.LandAnimals
{
    public class Monkey : ILandAnimals
    {
        public int Weight { get; set; }
        public string Says { get; }
        public Monkey()
        {
            Weight = 154;
            Says = "Monkey nothing say(";
        }
        public void Walk()
        {
            Console.WriteLine("Monkey walk(lol) and "+Says);
        }
    }
}
