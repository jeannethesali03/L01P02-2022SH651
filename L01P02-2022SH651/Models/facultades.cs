﻿using System.ComponentModel.DataAnnotations;

namespace L01P02_2022SH651.Models
{
    public class facultades
    {
        [Key] 
        public int id { get; set; }

        public string? facultad { get; set; }
    }
}
