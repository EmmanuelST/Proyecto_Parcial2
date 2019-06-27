﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Parcial2.Entidades
{
    public class Inscripcion
    {
        [Key]
        public int InscripcionId { get; set; }
        public int EstudianteId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public virtual List<InscripcionDetalles> Asiganturas {get;set ;}

        public Inscripcion()
        {
            InscripcionId = 0;
            EstudianteId = 0;
            Fecha = DateTime.Now;
            Monto = 0;
            Asiganturas = new List<InscripcionDetalles>();
        }

        public void CalcularMonto()
        {
            decimal total = 0;

            foreach(var item in Asiganturas)
            {
                total += item.SubTotal;
            }

            Monto = total;
        }
    }
}
