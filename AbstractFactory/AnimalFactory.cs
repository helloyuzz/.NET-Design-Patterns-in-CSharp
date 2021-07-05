using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory {
    public abstract class AnimalFactory {
        public abstract Herbivore GetHerbivore(string type);
        public abstract Carnivore GetCarnivore(string type);
    }
}
