using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson19
{
    class SpiderMan: Human, IClimb
    {
        public float Speed { get; set; }
        public override string Name { get; set; }

        public SpiderMan(string Name, int age, float speed) : base(Name, age)
        {
            Speed = speed;
        }

        void IClimb.Climb()
        {

        }

        void ISuperHero.ActivateSuperPowers()
        {

        }

        public override string ToString()
        {
            return base.ToString() + $"Speed: {Speed}";
        }
    }
}
