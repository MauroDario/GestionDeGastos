﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestionDeGastos.Models
{
    public class Frecuencia
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Ingrese un Tipo.")]
        public string Tipo { get; set; }
    }
}