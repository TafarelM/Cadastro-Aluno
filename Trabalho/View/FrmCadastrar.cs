using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//adicionaie
using Controller;
using ObjetoTransferencia;

namespace View
{
    public partial class FrmCadastrar : Form
    {
        //parar poder usar o metodo do clienteCadastrar
        AcaoNaTela acaoNaTelaSelecionada;

        public FrmCadastrar(AcaoNaTela acaoNaTela, Aluno aluno)
        {
            InitializeComponent();

            //guardando os dados para poder usar fora do frmClienteCadastrar
            this.acaoNaTelaSelecionada = acaoNaTela;

            if (acaoNaTela == AcaoNaTela.Inserir)
            {
                //INSERIR
                //muda o nome da tela
                this.Text = "Inserir Aluno";

            }
            else if (acaoNaTela == AcaoNaTela.Alterar)
            {
                //ALTERAR
                this.Text = "Alterar Aluno";

                //grava o conteudo no campo da tela
                txtCod.Text = aluno.idAluno.ToString();
                txtNome.Text = aluno.nome;
                txtSobrenome.Text = aluno.sobrenome;
                txtmCpf.Text = aluno.cpf;
                txtmRg.Text = aluno.rg;
                cbRgExp.Text = aluno.rgExp;
                dateTimeDataNasc.Text = aluno.dataNascimento.ToString();
                txtEmail.Text = aluno.email;
                if (aluno.sexo == "Masculino")
                {
                    rbtnMasculino.Checked = true;
                }
                else
                {
                    rbtnFeminino.Checked = true;
                }
                txtmTelefone.Text = aluno.telefone;
                txtCel.Text = aluno.celular;
                txtUsuario.Text = aluno.usuario.usuario;
                txtSenha.Text = aluno.usuario.senha;              

            }
            else if (acaoNaTela == AcaoNaTela.Consultar)
            {
                //CONSULTAR
                this.Text = "Consultar Aluno";

                //grava o conteudo no campo da tela
                txtCod.Text = aluno.idAluno.ToString();
                txtNome.Text = aluno.nome;
                txtSobrenome.Text = aluno.sobrenome;
                txtmCpf.Text = aluno.cpf;
                txtmRg.Text = aluno.rg;
                cbRgExp.Text = aluno.rgExp;
                dateTimeDataNasc.Text = aluno.dataNascimento.ToString();
                txtEmail.Text = aluno.email;
                if (aluno.sexo == "Masculino")
                {
                    rbtnMasculino.Checked = true;
                }
                else
                {
                    rbtnFeminino.Checked = true;
                }
                txtmTelefone.Text = aluno.telefone;
                txtCel.Text = aluno.celular;
                txtUsuario.Text = aluno.usuario.usuario;
                txtSenha.Text = aluno.usuario.senha; 

                //desabilitando os campos da tela
                txtCod.Enabled = false;
                txtNome.Enabled = false;
                txtSobrenome.Enabled = false;
                txtmCpf.Enabled = false;
                txtmRg.Enabled = false;
                cbRgExp.Enabled = false;
                dateTimeDataNasc.Enabled = false;
                txtEmail.Enabled = false;
                rbtnMasculino.Enabled = false;
                rbtnFeminino.Enabled = false;
                txtmTelefone.Enabled = false;
                txtCel.Enabled = false;
                txtUsuario.Enabled = false;
                txtSenha.Enabled = false;

                //mudando a text do botão e desabilitando ele
                btnSalvar.Visible = false;
                btnLimpar.Visible = false;
                btnCancelar.Text = "Fechar";
                btnCancelar.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SALVAR
            //verifica se é inserção ou alteração
            if (acaoNaTelaSelecionada.Equals(AcaoNaTela.Inserir))
            {
                //INSERIR

                Aluno aluno = new Aluno();
                aluno.usuario = new Usuario();

                aluno.nome = txtNome.Text;
                aluno.sobrenome = txtSobrenome.Text;
                aluno.cpf = txtmCpf.Text;
                aluno.rg = txtmRg.Text;
                aluno.rgExp = cbRgExp.Text;
                aluno.dataNascimento = dateTimeDataNasc.Value;
                aluno.email = txtEmail.Text;
                if (rbtnMasculino.Checked == true)
                {
                    aluno.sexo = "Masculino";//masculino
                }
                else
                {
                    aluno.sexo = "Feminino";//feminino
                }
                aluno.telefone = txtmTelefone.Text;
                aluno.celular = txtCel.Text;
                aluno.usuario.usuario = txtUsuario.Text;
                aluno.usuario.senha = txtSenha.Text;

                //VALIDAR CAMPOS

                //envia para o metodo tudo q foi colocado na classe cliente
                AlunoBLL alunoBLL = new AlunoBLL();
                string retorno = alunoBLL.Inserir(aluno);

                //Tenta converter para inteiro se der tudo certo é porque devolveu o códiggo do cliente se der errado tem a msg de erro
                try
                {
                    //salvo com sucessso
                    int idAluno = Convert.ToInt32(retorno);
                    MessageBox.Show("Inserido com Sucesso!.  Código: " + idAluno.ToString());
                    //
                    this.DialogResult = DialogResult.Yes;
                }
                catch
                {
                    //se der erro
                    MessageBox.Show("Não foi possivel Inserir. Detalhes: " + retorno, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }

            }
            else if (acaoNaTelaSelecionada.Equals(AcaoNaTela.Alterar))
            {
                //ALTERAR

                Aluno aluno = new Aluno();
                aluno.usuario = new Usuario();

                aluno.idAluno = Convert.ToInt32(txtCod.Text);
                aluno.nome = txtNome.Text;
                aluno.sobrenome = txtSobrenome.Text;
                aluno.cpf = txtmCpf.Text;
                aluno.rg = txtmRg.Text;
                aluno.rgExp = cbRgExp.Text;
                aluno.dataNascimento = dateTimeDataNasc.Value;
                aluno.email = txtEmail.Text;
                if (rbtnMasculino.Checked == true)
                {
                    aluno.sexo = "Masculino";//masculino
                }else {
                    aluno.sexo = "Feminino";//feminino
                }
                aluno.telefone = txtmTelefone.Text;
                aluno.celular = txtCel.Text;
                aluno.usuario.senha = txtUsuario.Text;
                aluno.usuario.senha = txtSenha.Text;

                //envia para o metodo tudo q foi colocado na classe cliente
                AlunoBLL alunoBLL = new AlunoBLL();
                string retorno = alunoBLL.Alterar(aluno);

                //Tenta converter para inteiro se der tudo certo é porque devolveu o códiggo do cliente se der errado tem a msg de erro
                try
                {
                    //salvo com sucessso
                    int idAluno = Convert.ToInt32(retorno);
                    MessageBox.Show("Registro Alterado com Sucesso!. ");
                    //
                    this.DialogResult = DialogResult.Yes;
                }catch {
                    //se der erro
                    MessageBox.Show("Não foi possivel Alterar o registro. Detalhes: " + retorno, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.No;
                }

            }            
        }

        //BOTÃO CANCELAR
        private void button2_Click(object sender, EventArgs e)
        {
            //cancelar
            DialogResult = DialogResult.No;
        }

        //BOTÃO LIMPAR
        private void button3_Click(object sender, EventArgs e)
        {
            //limpar
            txtNome.Text = null;
            txtSobrenome.Text = null;
            txtmCpf.Text = null;
            txtmRg.Text = null;
            //cbRgExp.Text = null;
            txtEmail.Text = null;
            rbtnMasculino.Checked = false;
            rbtnFeminino.Checked = false;
            txtmTelefone.Text = null;
            txtCel.Text = null;
            txtUsuario.Text = null;
            txtSenha.Text = null;            
        }

        private void FrmCadastrar_Load(object sender, EventArgs e)
        {
            EstadoBLL estadoBLL = new EstadoBLL();
            cbRgExp.DataSource = estadoBLL.ConsultarNome("");
            cbRgExp.DisplayMember = "SiglaEstado";
            cbRgExp.ValueMember = "IDEstado";
        }
    }
}
