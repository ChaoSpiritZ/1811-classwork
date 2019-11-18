using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1811_Classwork
{
    public abstract class Car
    {
        public Engine engine;

        public Car(Engine engine)
        {
            this.engine = engine;
        }

        public abstract void Go();

        public abstract void FixMyEngine(Garage garage);
    }
}
