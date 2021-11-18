using System;

namespace ProgramaTrainee
{
    public class classUsuario
    {
        public Int32 ID_Usuario { get; set; }
        public String Login { get; set; }
        public String Senha { get; set; }
        public String Nome { get; set; }
        public String Apelido { get; set; }
        public String Cargo { get; set; }
        public String Departamento { get; set; }
        public String Sexo { get; set; }
        public DateTime Data_criacao { get; set; }
        public DateTime Data_alteracao { get; set; }

    }
}
