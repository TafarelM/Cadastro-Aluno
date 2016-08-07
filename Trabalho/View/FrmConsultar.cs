using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//pegando

//adicionada
using BLL;
using ObjetoTransferencia;

namespace View
{
    public partial class FrmConsultar : Form
    {
        public FrmConsultar()
        {
            InitializeComponent();
            //para não gerar colunas automaticas no dataGrid
            dataGridViewConsultar.AutoGenerateColumns = false;
        }

        //METODO PARA ATUALIZAR O GRID
        private void AtualizarGrid()
        {
            //O METODO É O BOTÃO PESQUISAR
            //  PESQUISAR
            AlunoBLL aluno = new AlunoBLL();
            AlunoColecao alunoColecao = new AlunoColecao();


            //PASSA COMO PARAMETRO OQUE FOR DIGITADO NO CAMPO TXTPESQUISAR PARA O METODO CONSULTARNOME E OQUE FOR ENCONTRADO ELE VAI JOGAR NA COLEÇÃO DE CLIENTES
            alunoColecao = aluno.ConsultarNome(txtPesquisar.Text);

            //CONFIGURANDO O DATAGRID
            //limpando o dataGrid se caso ouver dados
            dataGridViewConsultar.DataSource = null;
            //usando a coleção de cliente como fonte de dados para o dataGrid
            dataGridViewConsultar.DataSource = alunoColecao;

            //
            dataGridViewConsultar.Update();
            dataGridViewConsultar.Refresh();
        }

        //BOTÃO CADASTRAR
        private void button2_Click(object sender, EventArgs e)
        {   
            //INSERIR
            FrmCadastrar frmCadastrar = new FrmCadastrar(AcaoNaTela.Inserir, null);            
            //pegando o dialogResult
            DialogResult dialogResult =  frmCadastrar.ShowDialog();
            //
            if (dialogResult.Equals(DialogResult.Yes))
            {
                AtualizarGrid();
            }
        }

        //BOTÃO EDITAR
        private void button4_Click(object sender, EventArgs e)
        {
            //BOTÃO ALTERAR

            //verificar se tem algum registro selecionado no grid
            if (dataGridViewConsultar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleciona um registro");
                return;
            }

            //pegar o cliente selecionado no grid
            Aluno alunoSelecionado = (dataGridViewConsultar.SelectedRows[0].DataBoundItem as Aluno);

            FrmCadastrar frmCadastrar = new FrmCadastrar(AcaoNaTela.Alterar, alunoSelecionado);

            DialogResult dialogResult = frmCadastrar.ShowDialog();
            if (dialogResult.Equals(DialogResult.Yes))
            {
                AtualizarGrid();
            }
        }

        //BOTÃO DELETAR
        private void button5_Click(object sender, EventArgs e)
        {
            //EXCLUIR
            //verificar se tem algum registro selecionado
            if (dataGridViewConsultar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleciona um registro");
                return;
            }
            //perguntar se ele tem certeza que excluir o registro
            DialogResult resultado = MessageBox.Show("Tem Certeza que deseja excluir esse registro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }

            //pegar o cliente selecionado
            Aluno alunoSelecionado = (dataGridViewConsultar.SelectedRows[0].DataBoundItem as Aluno);

            //Instanciar  a regra de negocioas
            AlunoBLL alunoBLL = new AlunoBLL();
            //chamar o metodo excluir e guarda na variavel retorno
            string retorno = alunoBLL.Excluir(alunoSelecionado);

            //verificar se a exlcusão funciono
            //se o retorno for numero é porque deu certo, senão deu erro
            try
            {
                //excluido com sucesso
                int idAluno= Convert.ToInt32(retorno);
                MessageBox.Show("Excluído com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarGrid();
            }
            catch
            {
                //se der erro
                MessageBox.Show("Não foi possivel excluir. Detalhes: " + retorno, "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //BOTÃO CONSULTAR
        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            //CONSULTAR

            //verificar se tem algum registro selecionado no grid
            if (dataGridViewConsultar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleciona um registro");
                return;
            }

            //pegar o cliente selecionado no grid
            Aluno alunoSelecionado = (dataGridViewConsultar.SelectedRows[0].DataBoundItem as Aluno);

            FrmCadastrar frmCadastrar = new FrmCadastrar(AcaoNaTela.Consultar, alunoSelecionado);
            frmCadastrar.ShowDialog();   
        }

        //BOTÃO DE PESQUISAR
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //criei o metodo com o codigo do botão para reutilizar codigo
            AtualizarGrid();
        }

        //BOTÃO FECHAR
        private void btnSair_Click(object sender, EventArgs e)
        {
            //sair
            Close();
        }
    }
}
