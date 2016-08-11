using System;

namespace ObjetoTransferencia
{
    public class Aluno
    {
        public int idAluno { get; set; }
        public string nome { get; set; }
        public string sobrenome { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string rgExp { get; set; }
        public DateTime dataNascimento { get; set; }
        public string email { get; set; }
        public string sexo { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        //public byte[] foto { get; set; }
        public Usuario usuario { get; set; }
    }
}
