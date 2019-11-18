using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1811_Classwork
{
    class Program
    {
        static void Main(string[] args)
        {
            SportEngine sport1 = new SportEngine(2.7f, true);
            SportCar wowie = new SportCar(150, sport1);

            SlowEngine slow1 = new SlowEngine(20, true);
            SportCar omgi = new SportCar(140, slow1);

            SportEngine sport2 = new SportEngine(2.8f, false);
            SportCar wowno = new SportCar(160, sport2);

            SlowEngine slow2 = new SlowEngine(30, false);
            SportCar omgno = new SportCar(170, slow2);

            Garage aGarage = new Garage();

            wowie.Go();
            omgi.Go();
            wowno.Go();
            omgno.Go();

            wowno.FixMyEngine(aGarage);

            wowie.Go();
            omgi.Go();
            wowno.Go();
            omgno.Go();
        }
    }
}
