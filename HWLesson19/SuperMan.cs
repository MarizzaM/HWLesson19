using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson19
{
    class SuperMan : Human, IFly
    {
        public float WebLeft { get; private set; }
        public override string Name { get; set; }

        public SuperMan(string Name, int age, float webleft) : base(Name, age)
        {
            WebLeft = webleft;
        }

        void IFly.Fly()
        {

        }

        void ISuperHero.ActivateSuperPowers()
        {
       
        }

        public override string ToString()
        {
            return base.ToString() + $"WebLeft: {WebLeft} ";
        }
    }
}
