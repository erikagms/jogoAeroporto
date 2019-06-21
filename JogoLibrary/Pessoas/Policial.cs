using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoLibrary.Pessoas
{
    class Policial: Pessoa
    {
        public Policial()
        {
            Dirige = true;
            Tripulante = false;
        }
    }
}
