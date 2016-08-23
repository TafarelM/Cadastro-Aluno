using System;

//referencias adicionadas
using ObjetoTransferencia;
using System.Data;

namespace DAL
{
    public class AlunoDAL
    {
        //instânciar  = criar um novo objeto baseado em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        //variavel escopo alunoBLL
        string retorno;

        public string Inserir(Aluno aluno)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adiciona
                acessoDadosSqlServer.AdicionarParametros("@Nome", aluno.nome);
                acessoDadosSqlServer.AdicionarParametros("@Sobrenome", aluno.sobrenome);
                acessoDadosSqlServer.AdicionarParametros("@CPF", aluno.cpf);
                acessoDadosSqlServer.AdicionarParametros("@RG", aluno.rg);
                acessoDadosSqlServer.AdicionarParametros("@RGExp", aluno.rgExp);
                acessoDadosSqlServer.AdicionarParametros("@DataNascimento", aluno.dataNascimento);
                acessoDadosSqlServer.AdicionarParametros("@Email", aluno.email);
                acessoDadosSqlServer.AdicionarParametros("@Sexo", aluno.sexo);
                acessoDadosSqlServer.AdicionarParametros("@Telefone", aluno.telefone);
                acessoDadosSqlServer.AdicionarParametros("@Celular", aluno.celular);
                // usuario
                acessoDadosSqlServer.AdicionarParametros("@Usuario", aluno.usuario.usuario);
                acessoDadosSqlServer.AdicionarParametros("@Senha", aluno.usuario.senha);
                //executa a manipulção
                string idAluno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "SP_Aluno_Inserir").ToString();
                return idAluno;
            }
            catch (Exception exception)
            {
                //exibi o erro que vc quiser
                //throw new Exception(exception.message);

                //retorna o erro que deu
                return exception.Message;
            }
        }

        public string Alterar(Aluno aluno)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("idAluno", aluno.idAluno);
                acessoDadosSqlServer.AdicionarParametros("@Nome", aluno.nome);
                acessoDadosSqlServer.AdicionarParametros("@Sobrenome", aluno.sobrenome);
                acessoDadosSqlServer.AdicionarParametros("@CPF", aluno.cpf);
                acessoDadosSqlServer.AdicionarParametros("@RG", aluno.rg);
                acessoDadosSqlServer.AdicionarParametros("@RGExp", aluno.rgExp);
                acessoDadosSqlServer.AdicionarParametros("@DataNascimento", aluno.dataNascimento);
                acessoDadosSqlServer.AdicionarParametros("@Email", aluno.email);
                acessoDadosSqlServer.AdicionarParametros("@Sexo", aluno.sexo);
                acessoDadosSqlServer.AdicionarParametros("@Telefone", aluno.telefone);
                acessoDadosSqlServer.AdicionarParametros("@Celular", aluno.celular);
                // usuario
                acessoDadosSqlServer.AdicionarParametros("@Usuario", aluno.usuario.usuario);
                acessoDadosSqlServer.AdicionarParametros("@Senha", aluno.usuario.senha);
                //executa e manipula
                string idAluno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "SP_Aluno_Alterar").ToString();
                return idAluno;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Excluir(Aluno aluno)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("idAluno", aluno.idAluno);
                //chamar a procedure para manipulação
                string idAluno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "SP_Aluno_Excluir").ToString();
                return idAluno;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public AlunoColecao ConsultarNome(string nome)
        {
            try
            {
                //Cria uma coleção nova de cliente(aqui ela está vazia)
                AlunoColecao alunoColecao = new AlunoColecao();
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@nome", nome);
                //manipulando dados e coloca dentro de um DataTable
                DataTable dataTableAluno = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "SP_Aluno_ConsultarPorNome");

                //percorrer o DataTable e transformar em uma coleção de clientes
                //cada linha do DataTable é uma cliente
                //o foreach vai percorrer cada linha(DataRow) pegando os dados que estiverem lá
                foreach (DataRow linha in dataTableAluno.Rows)
                {
                    //criar um cliente vazio e colocar os dados da linha nele e depois adiciona ele na colecao
                    Aluno aluno = new Aluno();
                    aluno.usuario = new Usuario();
                    //
                    aluno.idAluno = Convert.ToInt32(linha["IDAluno"]);
                    aluno.nome = Convert.ToString(linha["Nome"]);
                    aluno.sobrenome = Convert.ToString(linha["Sobrenome"]);
                    aluno.cpf = Convert.ToString(linha["CPF"]);
                    aluno.rg = Convert.ToString(linha["RG"]);
                    aluno.rgExp = Convert.ToString(linha["RGExp"]);
                    aluno.dataNascimento = Convert.ToDateTime(linha["DataNascimento"]);
                    aluno.email = Convert.ToString(linha["Email"]);
                    aluno.sexo = Convert.ToString(linha["Sexo"]);
                    aluno.telefone = Convert.ToString(linha["Telefone"]);
                    aluno.celular = Convert.ToString(linha["Celular"]);
                    //usuario
                    aluno.usuario.idUsuario = Convert.ToInt32(linha["IDUsuario"]);
                    aluno.usuario.usuario = Convert.ToString(linha["Usuario"]);
                    aluno.usuario.senha = Convert.ToString(linha["Senha"]);

                    //adiciona os dados de cliente na clienteColecao
                    alunoColecao.Add(aluno);
                }

                //retorna a coleção de crientes que foi encotrada no banco
                return alunoColecao;
            }
            catch (Exception exception)
            {
                //exibindo message caso de um erro na consuta(cria nova exeção)
                throw new Exception("Não foi possivel consultar o Aluno por nome. \nDetalhes: " + exception.Message);
            }

        }

        public AlunoColecao ConsultaId(int idAluno)
        {
            try
            {
                //Cria uma coleção nova de cliente(aqui ela está vazia)
                AlunoColecao alunoColecao = new AlunoColecao();
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@IDAluno", idAluno);
                //executar a consulta no banco e guarda o conteudo em um DataTable
                DataTable dataTableAluno = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "SP_Aluno_ConsultarPorID");

                foreach (DataRow linha in dataTableAluno.Rows)
                {
                    Aluno aluno = new Aluno();
                    aluno.usuario = new Usuario();

                    aluno.idAluno = Convert.ToInt32(linha["IDAluno"]);
                    aluno.nome = Convert.ToString(linha["Nome"]);
                    aluno.sobrenome = Convert.ToString(linha["Sobrenome"]);
                    aluno.cpf = Convert.ToString(linha["CPF"]);
                    aluno.rg = Convert.ToString(linha["RG"]);
                    aluno.rgExp = Convert.ToString(linha["RGExp"]);
                    aluno.dataNascimento = Convert.ToDateTime(linha["DataNascimento"]);
                    aluno.email = Convert.ToString(linha["Email"]);
                    aluno.sexo = Convert.ToString(linha["Sexo"]);
                    aluno.telefone = Convert.ToString(linha["Telefone"]);
                    aluno.celular = Convert.ToString(linha["Celular"]);
                    //usuario
                    aluno.usuario.idUsuario = Convert.ToInt32(linha["IDUsuario"]);
                    aluno.usuario.usuario = Convert.ToString(linha["Usuario"]);
                    aluno.usuario.senha = Convert.ToString(linha["Senha"]);

                    //adiciona a coleção
                    alunoColecao.Add(aluno);
                }

                return alunoColecao;
            }
            catch (Exception exception)
            {
                //exibindo message caso de um erro na consuta(cria nova exeção)
                throw new Exception("Não foi possivel consultar o Aluno por Código. \nDetalhes: " + exception.Message);
            }
        }

        public string LoginAluno(string usuarioL, string senhaL)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@Usuario", usuarioL);
                acessoDadosSqlServer.AdicionarParametros("@Senha", senhaL);
                //chamar a procedure para manipulação
                string retornoL = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "SP_Aluno_Login").ToString();
                return retornoL;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public string consultarCPF(string cpf)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@CPF", cpf);
                //chamar a procedure para manipulação
                string retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "SP_Aluno_ConsultarPorCPF").ToString();
                return retorno;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

        }

        public string RecuperarSenha(string usuario, DateTime dataNascimento, string cpf)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                retorno = null;
                //adicionar parametros
                acessoDadosSqlServer.AdicionarParametros("@Usuario", usuario);
                acessoDadosSqlServer.AdicionarParametros("@DataNascimento", dataNascimento);
                acessoDadosSqlServer.AdicionarParametros("@CPF", cpf);
                //chamar a procedure para manipulação

                retorno = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "SP_Aluno_RecuperarSenha").ToString();
                return retorno;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        //TROCAR SENHA NÃO PEGO
        /*
        public string TrocarSenha(int idAluno , string senha)
        {
            try
            {
                //limpar antes de usar
                acessoDadosSqlServer.LimparParametros();
                //adiciona
                acessoDadosSqlServer.AdicionarParametros("@idAluno", idAluno); 
                acessoDadosSqlServer.AdicionarParametros("@senha", senha);          

                //executa a manipulção
                string idAlunol = acessoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspAlunoTrocarSenha").ToString();
                return idAlunol;
            }
            catch (Exception exception)
            {
                //exibi o erro que vc quiser
                //throw new Exception(exception.message);

                //retorna o erro que deu
                return exception.Message;
            }
        }*/

    }
}