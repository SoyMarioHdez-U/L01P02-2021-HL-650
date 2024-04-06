using Microsoft.EntityFrameworkCore;


namespace L01P02_2021_HL_650.Models
{
    public class db_notasContext : DbContext
    {
        public db_notasContext(DbContextOptions options): base(options)
        {

        }
    }
}
