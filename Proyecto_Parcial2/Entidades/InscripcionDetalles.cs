﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Parcial2.Entidades;

namespace Proyecto_Parcial2.Entidades
{
    public class InscripcionDetalles
    {
        [Key]
        public int InscripcionDetallesId { get; set; }
        public int InscripcionId { get; set; }
        public int AsignaturaId { get; set; }
        /*[ForeignKey ("AsignaturaId")]
        public Asignaturas Asignatura { get; set; }*/
      
        public decimal SubTotal { get; set; }

        public InscripcionDetalles()
        {
            InscripcionDetallesId = 0;
            InscripcionId = 0;
            AsignaturaId = 0;
            SubTotal = 0;
            //Asignatura = new Asignaturas();
            
        }
    }
}
