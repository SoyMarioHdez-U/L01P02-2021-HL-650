using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;


namespace L01P02_2021_HL_650.Models
{
    public class db_notasContext : DbContext
    {
        public db_notasContext(DbContextOptions options): base(options)
        {

        }

        public DbSet<facultades> facultades { get; set;}
        public DbSet<alumnos> alumnos { get; set;}
        public DbSet<materias> materias { get; set;}
        public DbSet<departamentos> departamentos { get; set;}

    }
}
