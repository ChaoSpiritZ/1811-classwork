using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1811_Classwork
{
    public class SportEngine : Engine
    {
        public float cylinder;

        public SportEngine(float cylinder, bool isWorking) : base(2.0f, "Sport Engine", isWorking)
        {
            this.cylinder = cylinder;
        }
    }
}
