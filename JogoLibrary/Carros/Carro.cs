using JogoLibrary.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoLibrary.Carros
{
    public abstract class Carro
    {
        public Carro()
        {
            Passageiros = new List<Pessoa>();
        }
        public void AdicionarPassageiro(Pessoa passageiro)
        {
            if (Passageiros.Count >= QuantidadeMaximaDePassageiros)
            {
                throw new Exception("Você excedeu a quantidade máxima de passageiros");
            }

            Passageiros.Add(passageiro);
        }
        public void Andar()
        {
            if (!Passageiros.Exists(pessoa => pessoa.Dirige))
            {
                throw new Exception("Nenhum dos passageiros é um motorista");
            }

        }

        public List<Pessoa> Passageiros { get; set; }
        public abstract int QuantidadeMaximaDePassageiros { get; }
    }
}
