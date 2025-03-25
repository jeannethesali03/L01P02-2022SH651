using System.ComponentModel.DataAnnotations;

namespace L01P02_2022SH651.Models
{
    public class Departamento
    {
        [Key]
        public int id_departamento { get; set; }
        public string departamento { get; set; }
    }
}
