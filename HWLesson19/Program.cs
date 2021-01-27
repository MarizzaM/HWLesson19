using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson19
{
    class Program
    {
        static void Main(string[] args)
        {

            Flash evgeni = new Flash("Evgeni", 3, 120.0f);
            SpiderMan pavel = new SpiderMan("Pavel", 4, 10.1f);
            SuperMan alex = new SuperMan("Alex", 30, 400);

            ISuperHero[] superHeroes = new ISuperHero[] { evgeni, pavel, alex };

            foreach (ISuperHero superHero in superHeroes) {
                ActivateHero(superHero);
            }

        }

        static void ActivateHero(ISuperHero superHero) {
            superHero.ActivateSuperPowers();
        }

        static void IdentifyHero(ISuperHero superHero)
        {
            if (superHero is Flash) {
                Console.WriteLine("Flash detected");
            }
            if (superHero is SpiderMan)
            {
                Console.WriteLine("SpiderMan detected");
            }
            if (superHero is SuperMan)
            {
                Console.WriteLine("SuperMan detected");
            }
        }
        static void GetMoreHeroData(ISuperHero superHero)
        {
            Flash flash = superHero as Flash;
            if (superHero != null)
            {
                Console.WriteLine($"Additional information: .{flash.Voltage}");
            }
            SpiderMan spiderMan = superHero as SpiderMan;
            if (superHero != null)
            {
                Console.WriteLine($"Additional information: .{spiderMan.Speed}");
            }
            SuperMan superMan = superHero as SuperMan;
            if (superHero != null)
            {
                Console.WriteLine($"Additional information: .{superMan.WebLeft}");
            }
        }

        static ISuperHero CreateHero(string s)
        {
            switch (s)
            {
                case "Flash":
                    return new Flash("Evgeni", 3, 120.0f);
                case "SpiderMan":
                    return new SpiderMan("Pavel", 4, 10.1f);
                case "SuperMan":
                    return new SuperMan("Alex", 30, 400);

                default:
                    return null;
            }
        }
    }
}
