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
    public partial class CadastroMorador : Form
    {
        campovazio a = new campovazio();
        public CadastroMorador()
        {
            InitializeComponent();
        }


        private void CadastroMorador_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_NextsoftDataSet.Morador'. Você pode movê-la ou removê-la conforme necessário.
            this.moradorTableAdapter.Fill(this.bD_NextsoftDataSet.Morador);

        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            //chamando a classe de campo vazio

            if (a.senha(nomeTextBox, " Nome"))
                return;
            if (a.senha(quantidadedeBichoEstimacaoTextBox, "Quantidade"))
                nomeTextBox.Focus();

            //fim de classe vazio


            //iniciando condição para salvar
            if (MessageBox.Show("Tem certeza que deseja Salvar?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    this.Validate();//validadando os campos
                    this.moradorBindingSource.EndEdit();//tabela do banco de dados
                    this.tableAdapterManager.UpdateAll(this.bD_NextsoftDataSet);//banco de dados


                    MessageBox.Show("Registro Salvo com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);//condição if se caso ok!
                    this.moradorTableAdapter.Fill(this.bD_NextsoftDataSet.Morador);//tabela e banco e dados validando
                    BtnCadastrar.Enabled = this.bD_NextsoftDataSet.Morador.Rows.Count > 0; //botão e salvar todos os campos
                }
                catch (Exception)
                {
                    MessageBox.Show("O registro está sendo usado e não pode ser Salvo.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("O registro não foi salvo", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);//condição caso queira excluir o campo
                this.moradorTableAdapter.Fill(this.bD_NextsoftDataSet.Morador);//carrega dados na tabela 'bD_NextsoftDataSet.Morador
            }//fim da condição 


        } //Fim do botão salvar dados Familia
          //  
          //
          //
          //Início Botão Alterar
        private void BtnAlterar_Click(object sender, EventArgs e)
        {

            id_FamiliaTextBox.Enabled = true;
            nomeTextBox.Enabled = true;
            quantidadedeBichoEstimacaoTextBox.Enabled = true;
            id_FamiliaTextBox.Focus();
            if (MessageBox.Show("Tem certeza que deseja alterar o campo?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    this.Update();
                    this.moradorBindingSource.EndEdit();//tabela do banco de dados
                    this.tableAdapterManager.UpdateAll(this.bD_NextsoftDataSet);//banco de dado
                    BtnAlterar.Enabled = this.bD_NextsoftDataSet.Morador.Rows.Count > 0;
                    this.Validate();//Validando o campo
                    BtnAlterar.Enabled = this.bD_NextsoftDataSet.Morador.Rows.Count > 0;
                    MessageBox.Show("O registro foi alterado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information); //seria o botão e salvar todos os campos
                }
                catch (Exception)
                {
                    MessageBox.Show("O registro está sendo usado e não pode ser Salvo.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("O registro não foi alterado", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);//condição caso queira excluir o campo
                this.moradorTableAdapter.Fill(this.bD_NextsoftDataSet.Morador);//carrega dados na tabela 'bD_NextsoftDataSet.Morador

            }//fim da cond

        }//fim Btnalterar
         //
         //
         //  
         //Início botão excluir
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja Excluir?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    this.Validate();//validadando os campos
                    this.moradorBindingSource.EndEdit();//tabela do banco de dados
                    this.tableAdapterManager.UpdateAll(this.bD_NextsoftDataSet);//banco de dados


                    MessageBox.Show("Registro Excluido com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);//condição if se caso ok!
                    this.moradorTableAdapter.Fill(this.bD_NextsoftDataSet.Morador);//carrega dados na tabela 'bD_NextsoftDataSet.Morador
                    BtnExcluir.Enabled = this.bD_NextsoftDataSet.Morador.Rows.Count > 0; // o botão e deletando todos os campos
                }
                catch (Exception)
                {
                    MessageBox.Show("O registro está sendo usado e não pode ser deletado.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Exclusão Cancelada com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);//condição caso queira excluir o campo
                this.moradorTableAdapter.Fill(this.bD_NextsoftDataSet.Morador);//carrega dados na tabela 'bD_NextsoftDataSet.Morador
            }

        }//Fim Botão excluir
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


        ////
        ////
        /////Início do Botão Menu
        Thread c;
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            this.Close();//fechar o formulário
            c = new Thread(novo);//declarando a variável de thread
            c.SetApartmentState(ApartmentState.MTA);//responsável por chamar vários form
            c.Start();
        } ////Fim do Botão Menu

        private void novo()
        {
            Application.Run(new Menu());//abre o formulário menu
        }

        ////
        ////
        /////Início do Botão topo adicionar novo
        private void Adicionar(object sender, EventArgs e)
        {
            id_FamiliaTextBox.Enabled = true;
            nomeTextBox.Enabled = true;
            quantidadedeBichoEstimacaoTextBox.Enabled = true;
        }////Fim do Botão topo adicionar novo


            ////
         ////
        /////Início do Botão excluir topo
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja Excluir?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    this.Validate();//validadando os campos
                    this.moradorBindingSource.EndEdit();//tabela do banco de dados
                    this.tableAdapterManager.UpdateAll(this.bD_NextsoftDataSet);//banco de dados


                    MessageBox.Show("Registro Excluido com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);//condição if se caso ok!
                    this.moradorTableAdapter.Fill(this.bD_NextsoftDataSet.Morador);//carrega dados na tabela 'bD_NextsoftDataSet.Morador
                    BtnExcluir.Enabled = this.bD_NextsoftDataSet.Morador.Rows.Count > 0; // o botão e deletando todos os campos
                }
                catch (Exception)
                {
                    MessageBox.Show("O registro está sendo usado e não pode ser deletado.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Exclusão Cancelada com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);//condição caso queira excluir o campo
                this.moradorTableAdapter.Fill(this.bD_NextsoftDataSet.Morador);//carrega dados na tabela 'bD_NextsoftDataSet.Morador

            } /////Fim do Botão excluir topo
        }
                    ////
                   ////
        /////Início do Botão pesquisar topo
        private void consultaMoradorToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.moradorTableAdapter.ConsultaMorador(this.bD_NextsoftDataSet.Morador, consultaMoradorToolStripTextBox.Text + "%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }/////Fim do Botão Pesquisar
    }
}




