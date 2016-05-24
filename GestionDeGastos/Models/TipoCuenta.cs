using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestionDeGastos.Models
{
    public class TipoCuenta
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Ingrese descripción."),Display(Name ="Descripción")]
        public string Descripcion { get; set; }
        public string Icono { get; set; }
        public string Color { get; set; }
    }
}