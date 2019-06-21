using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoLibrary.Pessoas
{
    class Oficial: Pessoa
    {
        public Oficial()
        {
            Dirige = false;
            Tripulante = true;
        }
    }
}
