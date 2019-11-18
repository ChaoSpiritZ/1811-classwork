using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1811_Classwork
{
    public abstract class Engine
    {
        public float size;
        public string name;
        public bool isWorking;

        public Engine(float size, string name, bool isWorking)
        {
            this.size = size;
            this.name = name;
            this.isWorking = isWorking;
        }
    }
}
