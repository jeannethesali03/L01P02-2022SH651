using System.ComponentModel.DataAnnotations;


namespace L01P02_2022SH651.Models
{
    public class Facultad
    {
        [Key]
        public int id_facultad { get; set; }
        public string? facultad { get; set; }

    }
}
