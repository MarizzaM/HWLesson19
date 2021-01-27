using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson19
{
    class Flash : Human, IFlash
    {
        public float Voltage { get; private set; }
        public override string Name { get; set; }

        public Flash(string Name, int age, float voltage) : base (Name, age)
        {
            Voltage = voltage;
        }

        void IFlash.FireLightnings()
        {

        }

        void ISuperHero.ActivateSuperPowers()
        {
            
        }

        public override string ToString()
        {
            return base.ToString() + $"Voltage: {Voltage}";
        }
    }
}
