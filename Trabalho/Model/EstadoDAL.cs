﻿using System;

//referencias adicionadas
using ObjetoTransferencia;
using System.Data;

namespace DAL
{
    public class EstadoDAL
    {
        //instânciar  = criar um novo objeto baseado em um modelo
        AcessoDadosSqlServer acessoDadosSqlServer = new AcessoDadosSqlServer();

        public EstadoColecao ComboBox()
        {
            try
            {
                EstadoColecao estadoColecao = new EstadoColecao();
                //limpar antes de usar

                //executar a consulta no banco e guarda o conteudo em um DataTable
                DataTable dataTableAluno = acessoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "SP_Estado_ComboBox");
                //
                foreach (DataRow linha in dataTableAluno.Rows)
                {
                    Estado estado = new Estado();

                    estado.idEstado = Convert.ToInt32(linha["IDEstado"]);
                    estado.estado = Convert.ToString(linha["Estado"]);
                    estado.siglaEstado = Convert.ToString(linha["SiglaEstado"]);

                    //adiciona a coleção
                    estadoColecao.Add(estado);
                }

                return estadoColecao;
            }
            catch (Exception exception)
            {
                //exibindo message caso de um erro na consuta(cria nova exeção)
                throw new Exception("Não foi possivel consultar o Estado por Nome. \nDetalhes: " + exception.Message);
            }
        }
    }
}
