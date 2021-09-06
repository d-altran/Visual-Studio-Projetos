using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
    class Helicopter : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando vento, vento sudeste, ventos ok!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Pasageiros ok. Ligando as helices!");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando decolagem.");
        }
    }
}
