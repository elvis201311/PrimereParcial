using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PrimerParcial.Entidades
{
    class Entidades
    {
      
        [Key]
        public int Id { get; set; }
        public String Nombre { get; set; }
        public int Precio { get; set; }

        public Entidades()
        {
            Id = 0;
            Precio = 0;
            Nombre = "";
        }
    }
}
