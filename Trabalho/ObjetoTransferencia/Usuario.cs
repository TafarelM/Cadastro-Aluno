namespace ObjetoTransferencia
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }

        public override string ToString()
        {
            //return base.ToString();
            return usuario.ToString();
        }
    }
}
