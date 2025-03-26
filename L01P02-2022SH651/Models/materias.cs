using System.ComponentModel.DataAnnotations;

namespace L01P02_2022SH651.Models
{
    public class materias
    {
        [Key]
        public int id { get; set; }
        public string? materia { get; set; }
        public int unidades_valorativas { get; set; }
        public string? estado { get; set; }
    }
}
