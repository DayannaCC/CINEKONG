using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace CINEKONG.Models
{
    public class Usuario
    {
        public string Correo { get; set; }

        [Key]
        public string Contraseña { get; set; }
        [Required]
        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public DateTime FecNac { get; set; }

        
    }
}