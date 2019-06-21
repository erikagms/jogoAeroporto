using JogoLibrary.Carros;
using JogoLibrary.Lugares;
using JogoLibrary.Pessoas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoLibrary
{
    public class Controlador
    {
        public Terminal Terminal { get; set; }
        public Aviao Aviao { get; set; }
        public Carro Carro { get; set; }
        public Lugar LocalAtualDoCarro { get; set; }

        public void IniciarJogo()
        {
           
            Terminal = new Terminal(AdicionarTodasAsPessoas());
            
            Aviao = new Aviao();

            Carro = new SmartForTwo();

            LocalAtualDoCarro = Terminal;
            
        }

        public void AdicionarPassageiroAoCarro(Pessoa passageiro)
        {
            Carro.AdicionarPassageiro(passageiro);
            LocalAtualDoCarro.ListaDePessoas.Remove(passageiro);
        }

        public void AndarComOCarro()
        {
            LocalAtualDoCarro.VerificaPessoasNoLugar();
            Carro.Andar();
            MudarLocalAtual();
        }

        public void DescerDoCarro(Pessoa passageiro)
        {
            Carro.Passageiros.Remove(passageiro);
            LocalAtualDoCarro.ListaDePessoas.Add(passageiro);
        }

        private void MudarLocalAtual()
        {
            if (LocalAtualDoCarro == Terminal)
            {
                LocalAtualDoCarro = Aviao;
            }
            else
            {
                LocalAtualDoCarro = Terminal;
            }
        }

        private List<Pessoa> AdicionarTodasAsPessoas()
        {
            var ListaDePessoas = new List<Pessoa>();

            ListaDePessoas.Add(new Piloto());
            ListaDePessoas.Add(new Oficial());
            ListaDePessoas.Add(new Oficial());
            ListaDePessoas.Add(new ChefeDeServico());
            ListaDePessoas.Add(new Comissario());
            ListaDePessoas.Add(new Comissario());
            ListaDePessoas.Add(new Policial());
            ListaDePessoas.Add(new Presidiario());

            return ListaDePessoas;
        }
    }
}
