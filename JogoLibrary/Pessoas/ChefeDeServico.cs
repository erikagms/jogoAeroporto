using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoLibrary.Pessoas
{
    public class ChefeDeServico:Pessoa
    {
        public ChefeDeServico()
        {
            Dirige = true;
            Tripulante = true;
        }
    }
}
