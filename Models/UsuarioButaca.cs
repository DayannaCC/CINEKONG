using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace CINEKONG.Models
{
        using System.Collections.Generic;
    public class UsuarioButaca

    {
        
        public double subtotal { get; set; }

        
        public double costo { get; set; }
        
        
        public int cantidad { get; set; }
    

        
        public Butaca butaca{get;set;}
        
        public string idbut {get;set;}
        public Usuario usuario{get;set;}
        
        public string Correo {get;set;}
    }
}