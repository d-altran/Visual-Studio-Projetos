using Isp.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Azul", 2022, 4.0, 2, 2);
            Motorcycle motorcycle = new Motorcycle("Branca", 2021, 150);

            Console.ReadLine();
        }
    }
}
