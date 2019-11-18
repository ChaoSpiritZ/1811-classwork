using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1811_Classwork
{
    public class SlowEngine : Engine
    {
        public float minSpeed;

        public SlowEngine(float minSpeed, bool isWorking) : base(1.2f, "Slow Engine", isWorking)
        {
            this.minSpeed = minSpeed;
        }
    }
}
