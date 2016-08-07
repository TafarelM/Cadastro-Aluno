using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//referencias adicionadas
using Model;
using ObjetoTransferencia;
using System.Data;

namespace Controller
{
    public class EstadoBLL
    {
        public EstadoColecao ConsultarNome(string nome)
        {
            EstadoDAL dal = new EstadoDAL();
            EstadoColecao colecaoDTO = new EstadoColecao();
            colecaoDTO = dal.ConsultarNome(nome);

            return colecaoDTO;
        }
    }
}
