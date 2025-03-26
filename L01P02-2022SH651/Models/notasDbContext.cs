using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using L01P02_2022SH651.Models;

namespace L01P02_2022SH651.Models
{
    public class notasDbContext:DbContext
    {
        public notasDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<facultades> facultades { get; set; }
        public DbSet<materias> materias { get; set; }
        
    }
}
