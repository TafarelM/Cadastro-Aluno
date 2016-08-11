using System;
using System.Windows.Forms;

//adicionada
using BLL;

namespace View
{
    public partial class FrmRecuperarSenha : Form
    {
        public FrmRecuperarSenha()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AlunoBLL aluno = new AlunoBLL();

            string acesso = aluno.RecuperarSenha(textBox1.Text, dateTimePicker1.Value, textBox3.Text);
            try
            {
                int deu= Convert.ToInt32(acesso);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                FrmNovaSenha frmNovaSenha = new FrmNovaSenha();
                frmNovaSenha.ShowDialog();
            }
            catch
            {
                MessageBox.Show("campo não corresponde", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
