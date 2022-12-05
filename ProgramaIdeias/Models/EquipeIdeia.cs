using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace ProgramaIdeias.Models
{
    public class EquipeIdeia
    {
        [Key]
        public int IDEquipeIdeia { get; set; }

        [ForeignKey("Funcionario")]
        public int IDFuncionario{ get; set; }
        public virtual Funcionario? Funcionario { get; set; }

        [ForeignKey("Ideia")]
        public int IDIdeia { get; set; }
        public virtual Ideia? Ideia { get; set; }

        private readonly Contexto _context;
        public EquipeIdeia()
        {

        }
        public EquipeIdeia( int iDFuncionario, int iDIdeia)
        {
            IDFuncionario = iDFuncionario;
            IDIdeia = iDIdeia;
        }

        public EquipeIdeia(Contexto contexto)
        {
            _context= contexto;
        }
    }
}
