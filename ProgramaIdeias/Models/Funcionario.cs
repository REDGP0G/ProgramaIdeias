using System.ComponentModel.DataAnnotations;

namespace ProgramaIdeias.Models
{
    public class Funcionario
    {
        [Key]
        public int IDFuncionario { get; set; }
        public string Nome { get; set; }
        public int Matricula { get; set; }
        public string Setor { get; set; }
        public DateTime DataNascimento { get; set; }

    }
}
