﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionDeGastos.Models
{
    public class Cuenta
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public float Saldo { get; set; }
        public DateTime FechaCreacion { get; set; }
        
    }
}