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

        public DbSet<Facultad> Facultad { get; set; }
        public DbSet<Materia> Materia { get; set; }
        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<L01P02_2022SH651.Models.Alumno> Alumno { get; set; } = default!;

    }
}
