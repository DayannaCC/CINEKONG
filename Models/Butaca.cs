using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace CINEKONG.Models
{
    public class Butaca
    {
             
       [Key]
        [MaxLength(30)]
        public string idbut { get; set; }
        public string tipbut { get; set; }
        public string estbut { get; set; }   

         public List<UsuarioButaca> UsuarioButacas { get; set; }

        public Butaca(){
            UsuarioButacas= new List<UsuarioButaca>();
        } 
           
    }
}