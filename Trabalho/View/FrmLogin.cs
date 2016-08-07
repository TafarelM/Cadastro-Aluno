using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//adicionada
using BLL;
using ObjetoTransferencia;

namespace View
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmRecuperarSenha Rsenha = new FrmRecuperarSenha();
            Rsenha.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            AlunoBLL aluno = new AlunoBLL();

            int  acesso = Convert.ToInt16(aluno.LoginAluno(textBox1.Text, textBox2.Text));
            if (acesso == 1)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
