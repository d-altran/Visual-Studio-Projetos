using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro.Entities
{
    class Employeer
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employeer()
        {

        }
        public Employeer(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}
