using Microsoft.EntityFrameworkCore;

namespace ProgramaIdeias.Models
{
	public class Contexto : DbContext
	{

		public Contexto(DbContextOptions<Contexto> options) : base(options)
		{

		}
		public DbSet<Ideia> Ideia{ get; set; }
		public DbSet<Funcionario> Funcionario { get; set; }
		public DbSet<EquipeIdeia> EquipeIdeia { get; set; }
	}
}
