using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoLibrary.Pessoas
{
    class Comissario:Pessoa
    {
        public Comissario()
        {
            Dirige = false;
            Tripulante = true;
        }
    }
}
