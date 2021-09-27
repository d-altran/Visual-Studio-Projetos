using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brigde.Plataforms
{
    class YouTube : IPlatform
    {

        public YouTube()
        {
            ConfigureRMTP();
            Console.WriteLine("YouTube: Transmissão Iniciada.");
        }
        public void AuthToken()
        {
            Console.WriteLine("YouTube: Autorizando aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("YouTube: Configurando servidor RMTP.");
        }
    }
}
