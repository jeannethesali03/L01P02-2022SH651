using System.ComponentModel.DataAnnotations;


namespace L01P02_2022SH651.Models
{
    public class Alumno
    {
        [Key]
        public int id_alumno { get; set; }
        public string? codigo { get; set; }
        public string? nombre { get; set; }
        public string? apellidos { get; set; }
        public int dui { get; set; }
        public int estado { get; set; }
    }
}
