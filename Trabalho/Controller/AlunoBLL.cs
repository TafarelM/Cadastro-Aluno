using System;

//referencias adicionadas
using DAL;
using ObjetoTransferencia;
using System.Text.RegularExpressions;

namespace BLL
{
    public class AlunoBLL
    {
        public string Inserir(Aluno aluno)
        {
            try
            {
                if (aluno.nome.Trim().Length == 0)
                {
                    throw new Exception("O nome do Aluno é obrigatório");
                }

                if (aluno.cpf.Trim().Length == 0)
                {
                    throw new Exception("O CPF do Aluno é obrigatório");
                }

                if (Validacao.IsCpf(aluno.cpf) == false)
                {
                    throw new Exception("O CPF inválido");
                }

                if (aluno.rg.Trim().Length == 0)
                {
                    throw new Exception("O RG do Aluno é obrigatório");
                }

                if (aluno.celular.Trim().Length == 0)
                {
                    throw new Exception("O Celular do Aluno é obrigatório");
                }

                if (aluno.telefone.Trim().Length == 0)
                {
                    throw new Exception("O Telefone do Aluno é obrigatório!");
                }


                //*****VALIDACAO PARA EMAIL*****
                string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}"
                + "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\"
                + ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
                Regex re = new Regex(strRegex);
                if (!re.IsMatch(aluno.email))
                {
                    throw new Exception("Digite um email válido.");
                }

                AlunoDAL dal = new AlunoDAL();
                string retorno = dal.Inserir(aluno);

                return retorno;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Alterar(Aluno aluno)
        {
            try
            {
                if (aluno.nome.Trim().Length == 0)
                {
                    throw new Exception("O nome do Aluno é obrigatório");
                }

                if (aluno.cpf.Trim().Length == 0)
                {
                    throw new Exception("O CPF do Aluno é obrigatório");
                }

                if (Validacao.IsCpf(aluno.cpf) == false)
                {
                    throw new Exception("O CPF inválido");
                }

                if (aluno.rg.Trim().Length == 0)
                {
                    throw new Exception("O RG do Aluno é obrigatório");
                }

                if (aluno.celular.Trim().Length == 0)
                {
                    throw new Exception("O celular do Aluno é obrigatório");
                }

                if (aluno.telefone.Trim().Length == 0)
                {
                    throw new Exception("O Telefone do Aluno é obrigatório!");
                }

                //*****VALIDACAO PARA EMAIL*****
                string strRegex = "^([a-zA-Z0-9_\\-\\.]+)@((\\[[0-9]{1,3}"
                + "\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([a-zA-Z0-9\\-]+\\"
                + ".)+))([a-zA-Z]{2,4}|[0,9]{1,3})(\\]?)$";
                Regex re = new Regex(strRegex);
                if (!re.IsMatch(aluno.email))
                {
                    throw new Exception("Digite um email válido.");
                }

                AlunoDAL dal = new AlunoDAL();
                string retorno = dal.Alterar(aluno);

                return retorno;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
            
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

        public string consultarCPF(string cpf)
        {
            AlunoDAL dal = new AlunoDAL();
            string retorno = dal.consultarCPF(cpf);

            return retorno;
        }

        //TROCAR SENHA NÃO PEGO
        /*
        public string TrocarSenha(int idAluno , string senha)
        {

        }*/
    }
}