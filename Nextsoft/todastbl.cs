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
    public partial class todastbl : Form
    {
        Thread c;
        public todastbl()
        {
            InitializeComponent();
        }

        private void condominioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.condominioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bD_NextsoftDataSet);

        }

        private void todastbl_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bD_NextsoftDataSet1.relatorio'. Você pode movê-la ou removê-la conforme necessário.
            this.relatorioTableAdapter.Fill(this.bD_NextsoftDataSet1.relatorio);
            // TODO: esta linha de código carrega dados na tabela 'bD_NextsoftDataSet1.pesquisa'. Você pode movê-la ou removê-la conforme necessário.
            
            // TODO: esta linha de código carrega dados na tabela 'bD_NextsoftDataSet.Familia'. Você pode movê-la ou removê-la conforme necessário.
            this.familiaTableAdapter.Fill(this.bD_NextsoftDataSet.Familia);
            // TODO: esta linha de código carrega dados na tabela 'bD_NextsoftDataSet.Morador'. Você pode movê-la ou removê-la conforme necessário.
            this.moradorTableAdapter.Fill(this.bD_NextsoftDataSet.Morador);
            // TODO: esta linha de código carrega dados na tabela 'bD_NextsoftDataSet.Condominio'. Você pode movê-la ou removê-la conforme necessário.
            this.condominioTableAdapter.Fill(this.bD_NextsoftDataSet.Condominio);

        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            this.Close();//fechar o formulário
            c = new Thread(novo);//declarando a variável de thread
            c.SetApartmentState(ApartmentState.MTA);//responsável por chamar vários form
            c.Start();
        } 

        private void novo()
        {
            Application.Run(new Menu());//abre o formulário menu
        }////Fim do Botão Menu

                 ////
                /// 
             /// Início Botão sair
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
    }
       
}
   
