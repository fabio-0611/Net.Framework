using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Nextsoft
{
    public partial class Menu : Form
    {
        Thread a;
        public Menu()
        {
            InitializeComponent();
        }
                  ////
                ////
            ///Inicio do botão Cadastrar Condominio
        private void BtnCondominio_Click(object sender, EventArgs e)
        {
            this.Close();
            a = new Thread(condominio);
            a.SetApartmentState(ApartmentState.MTA);
            a.Start();
        } ////Fim do botão condominio
          ////Início de um método de thread
        private void condominio()
        {
            Application.Run(new Cadastro());

        }////Fim do metodo da thread
                  ////
                ////
         ///Inicio do botão Cadastrar Familia
        private void BtnFamilia_Click(object sender, EventArgs e)
        {
            this.Close();
            a = new Thread(familia);
            a.SetApartmentState(ApartmentState.MTA);
            a.Start();
        }////Fim botão Cadastrar Familia

        private void familia()
        {

            Application.Run(new CadastroFamilia());

        }////Fim do método thread

                     ////
                    ///
                  /// 
        ///Inicio do botão Cadastrar Morador
        private void BtnMorador_Click(object sender, EventArgs e)
        {
            this.Close();
            a = new Thread(morador);
            a.SetApartmentState(ApartmentState.MTA);
            a.Start();
        }////Fim do botão Cadastrar Morador

        private void morador()
        {
            Application.Run(new CadastroMorador());
        }

                 ////
               ////
            ////
        ///Inicio do botão Sair
        private void BtnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair do sistema?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)//abre uma caixa de dialago
            {
                try
                {
                    Close();
                    MessageBox.Show("Você saiu do sistema com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);//condição if se caso for sim!
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível sair do sistema, ele esta sendo usado!");
                }
            }
            else
            {
                MessageBox.Show("Sejá bem vindo novamente ao sistema", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);//caso for não no else
            }
        }////Fim do botão Sair
                  ////F
                ////
             ////Inicio de botão todas tabelas
        private void BtnTabelas_Click(object sender, EventArgs e)
        {
            this.Close();
            a = new Thread(todas);
            a.SetApartmentState(ApartmentState.MTA);
            a.Start();
        }

        private void todas()
        {
           Application.Run(new todastbl());
        }
    }
}
