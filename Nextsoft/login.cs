using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;// biblioteca de declarar um novo formulario

namespace Nextsoft
{
    public partial class login : Form
    {
        Thread n;
        public login()
        {
            InitializeComponent();
        }
        // iniciando comando botão conectar
        private void BtnConectar_Click(object sender, EventArgs e)
        {
         
            campovazio c = new campovazio(); // chamando classe de campo vazio
            if (c.senha(textBox1, "Usuário"))
                return;
            if (c.senha(textBox2, "Senha"))
                return; 
            // fim de declaração de campo vazio

            // condição if para usuário e senha
            if (textBox1.Text == "1234" && textBox2.Text == "1234") // valor de usuário e senha
            {

                MessageBox.Show("Sejá bem vindo ao sistema");
                this.Close(); // fecha o formulário login
                n = new Thread(novoform); // declaração para um novo formulário
                n.SetApartmentState(ApartmentState.MTA); //  declaração para poder chamar varios formulários
                n.Start(); //  iniciando o novo formulário

            }
            else
            {
                MessageBox.Show("Senha ou usuario inválidos!");
                textBox1.Focus();
                return;
            }// fim da declaração

        } // fim botão conectar

        private void novoform()// declarando o novoform
        {
            Application.Run(new Menu());// abrindo o formulário cadastro
        }

        // Botão sair
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        // fim botão sair
    }

}
