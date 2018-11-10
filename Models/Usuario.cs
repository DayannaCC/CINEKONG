using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace CINEKONG.Models
{
        using System.Collections.Generic;
    public class Usuario

    {
        [Key]
        [MaxLength(100)]
        public string Correo { get; set; }

        [Required(ErrorMessage="Es necesario que ingrese una contraseña")]
        [DataType(DataType.Password)]
        public string Contraseña { get; set; }
        
        [Required(ErrorMessage="Es necesario que ingrese sus nombres")]
        public string Nombres { get; set; }
        [Required(ErrorMessage="Es necesario que ingrese sus apellidos")]
        public string Apellidos { get; set; }

        [Required(ErrorMessage="Es necesario que ingrese su fecha de nacimiento")]
        public DateTime FecNac { get; set; }

        
        public List<UsuarioButaca> UsuarioButacas { get; set; }

        public Usuario(){
            UsuarioButacas= new List<UsuarioButaca>();
        }
             
    }
}