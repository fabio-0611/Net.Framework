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
    
    public partial class Cadastro : Form
    {
        Thread a;
        campovazio m = new campovazio();//classe de campo vazio
        public Cadastro()
        {
            InitializeComponent();
        }

        private void condominioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.condominioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_NextsoftDataSet);

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_NextsoftDataSet.Morador'. Você pode movê-la ou removê-la conforme necessário.
            this.moradorTableAdapter.Fill(this.bD_NextsoftDataSet.Morador);
            // TODO: esta linha de código carrega dados na tabela 'bD_NextsoftDataSet.Familia'. Você pode movê-la ou removê-la conforme necessário.
            this.familiaTableAdapter.Fill(this.bD_NextsoftDataSet.Familia);
            // TODO: esta linha de código carrega dados na tabela 'bD_NextsoftDataSet.Condominio'. Você pode movê-la ou removê-la conforme necessário.
            this.condominioTableAdapter.Fill(this.bD_NextsoftDataSet.Condominio);

        }
        //
        //
        //Inicio do botão salvar dados condominio
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {

            //chamando a classe de campo vazio
            if (m.senha(nomeTextBox, " Nome"))
                return;
            if (m.senha(bairroTextBox, " Bairro"))
                return;
           //fim de classe vazio
         
            
            //iniciando condição para salvar
            if (MessageBox.Show("Tem certeza que deseja Salvar?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    this.Validate();//validadando os campos
                    this.condominioBindingSource.EndEdit();//tabela do banco de dados
                    this.tableAdapterManager.UpdateAll(this.bD_NextsoftDataSet);//banco de dados
                    this.condominioTableAdapter.Fill(this.bD_NextsoftDataSet.Condominio);//tabela e banco e dados validando
                    BtnCadastrar.Enabled = this.bD_NextsoftDataSet.Condominio.Rows.Count > 0; //seria o botão e salvar todos os campos
                    MessageBox.Show("Registro Salvo com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);//condição if se caso ok!

                }  
                catch (Exception)
                {
                    MessageBox.Show("O registro está sendo usado e não pode ser Salvo.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("O registro não foi salvo", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);//condição caso queira excluir o campo
                this.condominioTableAdapter.Fill(this.bD_NextsoftDataSet.Condominio);//carrega dados na tabela 'bD_NextsoftDataSet.Condominio
            }//fim da condição 

        } //Fim do botão salvar dados condominio

        //
        //
        //Início botão Alterar
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            nomeTextBox.Enabled = true;
            bairroTextBox.Enabled = true;
            if (MessageBox.Show("Tem certeza que deseja alterar o campo?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    this.Update();
                    this.condominioBindingSource.EndEdit();//tabela do banco de dados
                    this.tableAdapterManager.UpdateAll(this.bD_NextsoftDataSet);//banco de dados
                    BtnAlterar.Enabled = this.bD_NextsoftDataSet.Condominio.Rows.Count > 0;

                    this.Validate();
                    BtnAlterar.Enabled = this.bD_NextsoftDataSet.Condominio.Rows.Count > 0;
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
                this.condominioTableAdapter.Fill(this.bD_NextsoftDataSet.Condominio);//carrega dados na tabela 'bD_NextsoftDataSet.Condominio
            }//fim da cond

        }//fim Btnalterar
        
          //
         //
         //Início Botão sair
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
        }//Fim botão sair
        //
        //
        //Inicio Botão excluir
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja Excluir?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    this.Validate();//validadando os campos
                    this.condominioBindingSource.EndEdit();//tabela do banco de dados
                    this.tableAdapterManager.UpdateAll(this.bD_NextsoftDataSet);//banco de dados


                    MessageBox.Show("Registro Excluido com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);//condição if se caso ok!
                    this.condominioTableAdapter.Fill(this.bD_NextsoftDataSet.Condominio);//carrega dados na tabela 'bD_NextsoftDataSet.Condominio
                    BtnExcluir.Enabled = this.bD_NextsoftDataSet.Condominio.Rows.Count > 0; //seria o botão e deletando todos os campos
                }
                catch (Exception)
                {
                    MessageBox.Show("O registro está sendo usado e não pode ser deletado.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Exclusão Cancelada com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);//condição caso queira excluir o campo
                this.condominioTableAdapter.Fill(this.bD_NextsoftDataSet.Condominio);//carrega dados na tabela 'bD_NextsoftDataSet.Morador
            }

        }//Fim Botão excluir
                 //
            //
        //Botão adicionar novo cadastro
        private void Novo(object sender, EventArgs e)
        {
            nomeTextBox.Enabled = true;
            bairroTextBox.Enabled = true;
        }//fim botão adicionar

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja Excluir?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    this.Validate();//validadando os campos
                    this.condominioBindingSource.EndEdit();//tabela do banco de dados
                    this.tableAdapterManager.UpdateAll(this.bD_NextsoftDataSet);//banco de dados


                    MessageBox.Show("Registro Excluido com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);//condição if se caso ok!
                    this.condominioTableAdapter.Fill(this.bD_NextsoftDataSet.Condominio);//tabela e banco e dados validando
                    bindingNavigatorDeleteItem.Enabled = this.bD_NextsoftDataSet.Condominio.Rows.Count > 0; //seria o botão e deletando todos os campos
                }
                catch (Exception)
                {
                    MessageBox.Show("O registro está sendo usado e não pode ser deletado.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Exclusão Cancelada com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);//condição caso queira excluir o campo
                this.condominioTableAdapter.Fill(this.bD_NextsoftDataSet.Condominio);//tbl cliente+ banco de dados BD_Moura
            }

        }//Fim Botão excluir

            //
         //
       //

        //Início da pesquisa

        private void nome3ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.familiaTableAdapter.Nome3(this.bD_NextsoftDataSet.Familia, nomeToolStripTextBox.Text+"%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }//Fim Botão Pesquisa

        }


                  ////
             ////
        /////Início do Botão Menu
        Thread b;
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            this.Close();//fechar o formulário
            b= new Thread(novo);//declarando a variável de thread
            b.SetApartmentState(ApartmentState.MTA);//responsável por chamar vários form
            b.Start();
        } ////Fim do Botão Menu

        private void novo()
        {
            Application.Run(new Menu());//abre o formulário menu
        }
    }
}
    


   

