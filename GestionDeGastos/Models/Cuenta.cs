using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestionDeGastos.Models
{
    public class Cuenta
    {
        public int ID { get; set; }

        [Required(), Display(Name = "Tipo")
            NotMapped()]
        public int TipoID { get; set; }
        
        public virtual TipoCuenta Tipo { get; set; }
        [Required()]
        public string Nombre { get; set; }
        [Required()]
        public decimal Saldo { get; set; }
        [Required(), Display(Name = "Fecha de Creacion"), DataType(DataType.Date)]
        public DateTime FechaCreacion { get; set; }

        [NotMapped()]
        public string DescripcionTipoDeCuenta { get { return Tipo.Descripcion; } }
    }
}