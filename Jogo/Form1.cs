using JogoLibrary;
using JogoLibrary.Pessoas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo
{
    public partial class Jogo : Form
    {
        private Controlador controlador;

        public Jogo()
        {
            controlador = new Controlador();
            InitializeComponent();
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {

            controlador.IniciarJogo();
            AtualizarListBox();
            EstadoInicialComponentes();
        }

        private void Andar_Click(object sender, EventArgs e)
        {
            try
            {
                controlador.AndarComOCarro();
                MudarPosicaoCarro();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                AtualizarListBox();
            }
        }

        private void ListaTerminal_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (ListaTerminal.SelectedItem != null)
                    controlador.AdicionarPassageiroAoCarro((Pessoa)ListaTerminal.SelectedItem);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                AtualizarListBox();
            }
        }

        private void ListaCarro_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (ListaCarro.SelectedItem != null)
                    controlador.DescerDoCarro((Pessoa)ListaCarro.SelectedItem);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                AtualizarListBox();
            }
        }

        private void ListaAviao_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (ListaAviao.SelectedItem != null)
                    controlador.AdicionarPassageiroAoCarro((Pessoa)ListaAviao.SelectedItem);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                AtualizarListBox();
            }
        }

        private void ConcluirJogo()
        {
            MessageBox.Show("Parabéns jogo concluído!");
            ListaTerminal.Enabled = false;
            ListaCarro.Enabled = false;
            Andar.Enabled = false;
            ListaAviao.Enabled = false;
        }

        private void MudarNomes()
        {
            throw new NotImplementedException();
        }
        private void AtualizarListBox()
        {
            var terminal = new BindingSource();
            var carro = new BindingSource();
            var aviao = new BindingSource();
            terminal.DataSource = controlador.Terminal.ListaDePessoas;
            carro.DataSource = controlador.Carro.Passageiros;
            aviao.DataSource = controlador.Aviao.ListaDePessoas;
            ListaTerminal.DataSource = terminal;
            ListaCarro.DataSource = carro;
            ListaAviao.DataSource = aviao;


            if (!controlador.Terminal.ListaDePessoas.Any() &&
                !controlador.Carro.Passageiros.Any())
                ConcluirJogo();
        }
        private void EstadoInicialComponentes()
        {
            ListaTerminal.Enabled = true;
            ListaCarro.Enabled = true;
            Andar.Enabled = true;
            ListaAviao.Enabled = false;
            MudarPosicaoCarro();
        }
        private void MudarPosicaoCarro()
        {
            if (controlador.LocalAtualDoCarro == controlador.Terminal)
            {
                painelCarro.Location = new Point(188, 52);
                ListaTerminal.Enabled = true;
                ListaAviao.Enabled = false;
            }
            else
            {
                painelCarro.Location = new Point(322, 52);
                ListaTerminal.Enabled = false;
                ListaAviao.Enabled = true;
            }
        }
    }
}
