using System.ComponentModel.DataAnnotations;

namespace L01P02_2022SH651.Models
{
    public class Materia
    {
        [Key]
        public int id_materia { get; set; }
        public string? materia { get; set; }
        public int unidades_valorativas { get; set; }
        public string? estado { get; set; }
    }
}
