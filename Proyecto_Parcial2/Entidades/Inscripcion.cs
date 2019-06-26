using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Parcial2.Entidades
{
    public class Inscripcion
    {
        public int InscripcionId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }

        public Inscripcion()
        {
            InscripcionId = 0;
            Fecha = DateTime.Now;
            Monto = 0;
        }
    }
}
