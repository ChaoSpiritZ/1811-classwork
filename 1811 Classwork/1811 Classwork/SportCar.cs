using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1811_Classwork
{
    public class SportCar : Car
    {
        public int horsePower;

        public SportCar(int horsePower, Engine engine) : base(engine)
        {
            this.horsePower = horsePower;
        }

        public override void Go()
        {
            if (engine.isWorking == true)
            {
                Console.WriteLine($"Driving in {horsePower} horse power");
            }
            else
            {
                Console.WriteLine("Engine is broken!");
            }
        }

        public override void FixMyEngine(Garage garage)
        {
            garage.FixEngine(this);
        }
    }
}
