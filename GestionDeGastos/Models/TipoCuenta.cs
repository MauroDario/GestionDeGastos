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
        [Required(ErrorMessage ="Ingrese descripción.")]
        public string Descripcion { get; set; }
    }
}