using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        //MENU ITEM SAIR
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //AO CARREGAR A TELA
        private void FrmMenu_Load(object sender, EventArgs e)
        {
            //ao abri o menu
        }

        //BOTÃO SAIR
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //BOTÃO CONSULTAR
        private void button2_Click(object sender, EventArgs e)
        {
            FrmConsultar frmConsultar = new FrmConsultar();
            frmConsultar.ShowDialog();

        }
        //BOTÃO CADASTRAR
        private void button1_Click(object sender, EventArgs e)
        {
            FrmCadastrar frmCadastrar = new FrmCadastrar(AcaoNaTela.Inserir, null);
            frmCadastrar.ShowDialog();
        }
        //HORÁRIO
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        //MENU ITEM CADASTRAR ALUNO
        private void alunoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmCadastrar frmCadastrar = new FrmCadastrar(AcaoNaTela.Inserir, null);
            frmCadastrar.ShowDialog();
        }


        //MENU ITEM CONSULTAR ALUNO
        private void alunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultar frmConsultar = new FrmConsultar();
            frmConsultar.ShowDialog();
        }

        //MENU ITEM RELATORIO ALUNO
        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
