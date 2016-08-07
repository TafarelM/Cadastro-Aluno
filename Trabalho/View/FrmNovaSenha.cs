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
using Controller;
using ObjetoTransferencia;

namespace View
{
    public partial class FrmNovaSenha : Form
    {
        public FrmNovaSenha()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            //FAILLL 

            /*
            if (txtCampo1.Equals(txtCampo2))
            {
                //comando para mudar a senha
                AlunoDTO aluno = new AlunoDTO();
                aluno.idAluno = retorno;

                string acesso = aluno.TrocarSenha(txtCampo1.Text);
                if (acesso.Equals(1))
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    FrmNovaSenha frmNovaSenha = new FrmNovaSenha();
                    frmNovaSenha.ShowDialog();
                }
                else
                {
                    MessageBox.Show("campo não corresponde", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
               //mensagem que as senhas não iguais
                MessageBox.Show("AS senhas não coincidem");
            }*/
        }
    }
}
