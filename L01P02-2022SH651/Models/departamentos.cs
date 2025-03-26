using System.ComponentModel.DataAnnotations;

namespace L01P02_2022SH651.Models
{
    public class departamentos
    {
        [Key]
        public int id { get; set; }
        public string? departamento { get; set; }       
    }
}
