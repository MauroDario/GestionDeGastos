using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestionDeGastos.Models
{
    public class Categoria
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Ingrese un nombre.")]
        public string Nombre { get; set; }
        [Display(Name ="Descripción")
            Required(ErrorMessage = "Ingrese una descripción.")]
        public string Descripcion { get; set; }
    }
}