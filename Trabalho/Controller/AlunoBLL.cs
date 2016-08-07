using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//referencias adicionadas
using DAL;
using ObjetoTransferencia;
using System.Data;

namespace BLL
{
    public class AlunoBLL
    {

        public string Inserir(Aluno aluno)
        {
            AlunoDAL dal = new AlunoDAL();
            string retorno = dal.Inserir(aluno);

            return retorno;
        }

        public string Alterar(Aluno aluno)
        {
            AlunoDAL dal = new AlunoDAL();
            string retorno = dal.Alterar(aluno);

            return retorno;
        }

        public string Excluir(Aluno aluno)
        {
            AlunoDAL dal = new AlunoDAL();
            string retorno = dal.Excluir(aluno);

            return retorno;
        }

        public AlunoColecao ConsultarNome(string nome)
        {
            AlunoDAL dal = new AlunoDAL();
            AlunoColecao colecaoDTO = new AlunoColecao();
            colecaoDTO = dal.ConsultarNome(nome);

            return colecaoDTO;
        }

        public AlunoColecao ConsultaId(int idAluno)
        {
            AlunoDAL dal = new AlunoDAL();
            AlunoColecao colecaoDTO = new AlunoColecao();
            colecaoDTO = dal.ConsultaId(idAluno);

            return colecaoDTO;
        }

        public string LoginAluno(string usuarioL, string senhaL)
        {
            AlunoDAL dal = new AlunoDAL();
            string retorno = dal.LoginAluno(usuarioL, senhaL);

            return retorno;
        }

        public string RecuperarSenha(string usuario, DateTime dataNascimento, string cpf)
        {
            AlunoDAL dal = new AlunoDAL();
            string retorno = dal.RecuperarSenha(usuario, dataNascimento, cpf);

            return retorno;
        }

        //TROCAR SENHA NÃO PEGO
        /*
        public string TrocarSenha(int idAluno , string senha)
        {

        }*/
    }
}