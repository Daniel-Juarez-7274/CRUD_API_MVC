using CRUD_API.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUD_API.Context
{
	public class AppDbContext : DbContext
	{
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Empleado> Empleados { get; set; }
		public DbSet<Perfil> Perfiles { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Perfil>(tb =>
			{
				tb.HasKey(col => col.IdPerfil);
				tb.Property(col => col.IdPerfil).UseIdentityColumn().ValueGeneratedOnAdd();
				tb.Property(col => col.Nombre).E
			})
		}
	}
}
