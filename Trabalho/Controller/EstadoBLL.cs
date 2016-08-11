using DAL;
using ObjetoTransferencia;

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
