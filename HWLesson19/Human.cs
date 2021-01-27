using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWLesson19
{
    abstract class Human
    {
        public abstract string Name { get; set; }
        private int age;

        public int Age
        {
            get
            {
                return this.age;
            }
        }

        protected Human(string name, int age)
        {
            Name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"Human: {Name}, are: {Age}";
        }
    }
}
