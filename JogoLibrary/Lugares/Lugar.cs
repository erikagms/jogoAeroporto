using JogoLibrary.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoLibrary.Lugares
{
    public class Lugar
    {
        public Lugar(List<Pessoa> list)
        {
            ListaDePessoas = list;
        }
        
        public List<Pessoa> ListaDePessoas { get; }

        public void VerificaPessoasNoLugar()
        {
            VerificaRegraDoPiloto();
            VerificaRegraDoChefeDeServico();
            VerificaRegraDoPresidiario();
        }
        private void VerificaRegraDoPiloto()
        {
            if ((ListaDePessoas.Exists(pessoa => pessoa is Piloto)
                && ListaDePessoas.Exists(pessoa => pessoa is Comissario))
                && !ListaDePessoas.Exists(pessoa => pessoa is ChefeDeServico))
            {
                throw new Exception("O piloto não pode ficar sozinho com um comissário");
            }
        }
        private void VerificaRegraDoChefeDeServico()
        {
            if ((ListaDePessoas.Exists(pessoa => pessoa is ChefeDeServico)
                && ListaDePessoas.Exists(pessoa => pessoa is Oficial))
                && !ListaDePessoas.Exists(pessoa => pessoa is Piloto))
            {
                throw new Exception("O chefe de serviço não pode ficar sozinho com um oficial");
            }
        }
        private void VerificaRegraDoPresidiario()
        {

            if ((ListaDePessoas.Exists(pessoa => pessoa is Presidiario)
                && ListaDePessoas.Exists(pessoa => pessoa.Tripulante == true))
                && !ListaDePessoas.Exists(pessoa => pessoa is Policial))
            {                
                throw new Exception("O presidiário não pode ficar sem um policial");
            }
        }

    }
}
