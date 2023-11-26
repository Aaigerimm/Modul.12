using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul._12
{
    public class SportsCar : Car
    {
        public SportsCar(string name) : base(name, 10) { }
    }

    public class SedanCar : Car
    {
        public SedanCar(string name) : base(name, 8) { }
    }

    public class Truck : Car
    {
        public Truck(string name) : base(name, 5) { }
    }

    public class Bus : Car
    {
        public Bus(string name) : base(name, 7) { }
    }
}
