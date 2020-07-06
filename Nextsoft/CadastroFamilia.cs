using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; // biblioteca para chamar outro formulário
namespace Nextsoft
{
    
    public partial class CadastroFamilia : Form
    {
        campovazio v = new campovazio();
        Thread a; //declarando uma variável de thread
        public CadastroFamilia()
        {
            InitializeComponent();
        }

        private void familiaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.familiaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_NextsoftDataSet);

        }

        private void CadastroFamilia1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_NextsoftDataSet.Familia'. Você pode movê-la ou removê-la conforme necessário.
            this.familiaTableAdapter.Fill(this.bD_NextsoftDataSet.Familia);

        }
                        //
                     //
                 //
             //Inicio botão cadastrar
        private void BtnCadastrar_Click(object sender, EventArgs e)
        {

            //chamando a classe de campo vazio
            if (v.senha(nomeTextBox, " Nome"))
                return;
             nomeTextBox.Focus();
            
            //fim de classe vazio


            //iniciando condição para salvar
            if (MessageBox.Show("Tem certeza que deseja Salvar?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    this.Validate();//validadando os campos
                    this.familiaBindingSource.EndEdit();//tabela do banco de dados
                    this.tableAdapterManager.UpdateAll(this.bD_NextsoftDataSet);//banco de dados


                    MessageBox.Show("Registro Salvo com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);//condição if se caso ok!
                    this.familiaTableAdapter.Fill(this.bD_NextsoftDataSet.Familia);//tabela e banco e dados validando
                    BtnCadastrar.Enabled = this.bD_NextsoftDataSet.Familia.Rows.Count > 0; //botão e salvar todos os campos
                }
                catch (Exception)
                {
                    MessageBox.Show("O registro está sendo usado e não pode ser Salvo.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("O registro não foi salvo", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);//condição caso queira excluir o campo
                this.familiaTableAdapter.Fill(this.bD_NextsoftDataSet.Familia);//carrega dados na tabela 'bD_NextsoftDataSet.Familia
            }//fim da condição 

                  
        } //Fim do botão salvar dados Familia
                            //  
                      //
                 //
          //Início Botão Alterar
        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            nomeTextBox.Enabled = true;
            id_CondominioTextBox.Enabled = true;
            if (MessageBox.Show("Tem certeza que deseja alterar o campo?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    this.Update();
                    this.familiaBindingSource.EndEdit();//tabela do banco de dados
                    this.tableAdapterManager.UpdateAll(this.bD_NextsoftDataSet);//banco de dado
                    BtnAlterar.Enabled = this.bD_NextsoftDataSet.Familia.Rows.Count > 0;
                     this.Validate();//Validando o campo
                    BtnAlterar.Enabled = this.bD_NextsoftDataSet.Familia.Rows.Count > 0;
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
                this.familiaTableAdapter.Fill(this.bD_NextsoftDataSet.Familia);//carrega dados na tabela 'bD_NextsoftDataSet.Familia

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
                    this.familiaBindingSource.EndEdit();//tabela do banco de dados
                    this.tableAdapterManager.UpdateAll(this.bD_NextsoftDataSet);//banco de dados


                    MessageBox.Show("Registro Excluido com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);//condição if se caso ok!
                    this.familiaTableAdapter.Fill(this.bD_NextsoftDataSet.Familia);//carrega dados na tabela 'bD_NextsoftDataSet.Familia
                    BtnExcluir.Enabled = this.bD_NextsoftDataSet.Familia.Rows.Count > 0; // o botão e deletando todos os campos
                }
                catch (Exception)
                {
                    MessageBox.Show("O registro está sendo usado e não pode ser deletado.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Exclusão Cancelada com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);//condição caso queira excluir o campo
                this.familiaTableAdapter.Fill(this.bD_NextsoftDataSet.Familia);//carrega dados na tabela 'bD_NextsoftDataSet.Familia
            }

        }//Fim Botão excluir
                //
              //
            // 
        //Inicio botão sair 
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
                 ////
            /////
         ////Adicionar um novo cadastro
        private void NovoFamilia(object sender, EventArgs e)
        {
            nomeTextBox.Enabled = true;
            id_CondominioTextBox.Enabled = true;
        }////fim botão adicionar novo cadastro

                     ////
                 /////
             ////Excluir um cadastro  botão topo
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja Excluir?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    this.Validate();//validadando os campos
                    this.familiaBindingSource.EndEdit();//tabela do banco de dados
                    this.tableAdapterManager.UpdateAll(this.bD_NextsoftDataSet);//banco de dados


                    MessageBox.Show("Registro Excluido com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);//condição if se caso ok!
                    this.familiaTableAdapter.Fill(this.bD_NextsoftDataSet.Familia);//carrega dados na tabela 'bD_NextsoftDataSet.Familia
                    bindingNavigatorDeleteItem.Enabled = this.bD_NextsoftDataSet.Familia.Rows.Count > 0; // o botão e deletando todos os campos
                }
                catch (Exception)
                {
                    MessageBox.Show("O registro está sendo usado e não pode ser deletado.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Exclusão Cancelada com Sucesso", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);//condição caso queira excluir o campo
                this.familiaTableAdapter.Fill(this.bD_NextsoftDataSet.Familia);//carrega dados na tabela 'bD_NextsoftDataSet.Familia
            }
        }////fim botão excluir cadastro topo cadastro
                  ////
               ////
            ///Inicio do botão pesquisar
        private void consultarToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.familiaTableAdapter.Consultar(this.bD_NextsoftDataSet.Familia, consultarToolStripTextBox.Text +"%");
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }    ///Fim do botão pesquisar

        }
                 ////
             ////
           /////Início do Botão Menu
        private void BtnMenu_Click(object sender, EventArgs e)
        {
            this.Close();//fechar o formulário
            a = new Thread(novo);//declarando a variável de thread
            a.SetApartmentState(ApartmentState.MTA);//responsável por chamar vários form
            a.Start();
        } ////Fim do Botão Menu

        private void novo()
        {
            Application.Run(new Menu());//abre o formulário menu
        }
    }


}




