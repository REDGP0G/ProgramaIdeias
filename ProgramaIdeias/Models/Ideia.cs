using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace ProgramaIdeias.Models
{
    public class Ideia
    {
        [Key]
        public int IDIdeia { get; set; }

        [Display(Name = "Descrição da Ideia")]
        public string Descricao { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }
        public float? Ganho { get; set; }

        [Display(Name = "Ganho")]
        public string? DescricaoGanho { get; set; }
        public float Investimento { get; set; }
        public string? Feedback { get; set; }
        [Display(Name = "Nome da Equipe")]
        public string? NomeEquipe { get; set; }

        public virtual List<EquipeIdeia>? EquipeIdeia { get; set; }

        [NotMapped]
        public List<int>? Participantes { get; set; }

        private readonly Contexto _context;
        public Ideia()
        {

        }
        public Ideia(Contexto contexto)
        {
            _context= contexto;
        }
        public List<Ideia> GetIdeias()
        {
            return _context.Ideia.ToList();
        }
        public List<Funcionario> GetFuncionarios()
        {
            return _context.Funcionario.ToList();
        }
	}
}
