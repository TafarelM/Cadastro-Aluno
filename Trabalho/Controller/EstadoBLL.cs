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
    public class EstadoBLL
    {
        public EstadoColecao ComboBox()
        {
            EstadoDAL dal = new EstadoDAL();
            EstadoColecao colecaoDTO = new EstadoColecao();
            colecaoDTO = dal.ComboBox();

            return colecaoDTO;
        }
    }
}
