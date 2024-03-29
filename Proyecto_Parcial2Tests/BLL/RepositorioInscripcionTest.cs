﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto_Parcial2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Parcial2.BLL;

namespace Proyecto_Parcial2Tests.BLL
{ 
    [TestClass()]
    public class RepositorioInscripcionTest
    {
        [TestMethod()]
        public void Guardar()
        {
            RepositorioInscripcion db = new RepositorioInscripcion();
            //RepositorioBase<Estudiantes> estudiante = new RepositorioBase<Estudiantes>();

            List<InscripcionDetalles> lista = new List<InscripcionDetalles>();

            lista.Add(new InscripcionDetalles()
            {
                AsignaturaId = 1,
                InscripcionDetallesId = 0,
                InscripcionId = 0,
                SubTotal = 100,
                //Asignatura = new Asignaturas() {AsignaturaId = 1 }
            }) ;

            /*lista.Add(new InscripcionDetalles()
            {
                AsignaturaId = 1,
                InscripcionDetallesId = 0,
                InscripcionId = 0,
                SubTotal = 100,
                //Asignatura = new Asignaturas() { AsignaturaId = 1 }
            });*/

            Inscripcion inscripcion = new Inscripcion()
            {
                InscripcionId = 0,
                EstudianteId = 1,
                Fecha = DateTime.Now,
                Asignaturas = lista
            };
            inscripcion.CalcularMonto();

           // var temp = estudiante.Buscar(inscripcion.EstudianteId);
           // temp.Balance += inscripcion.Monto;
            //estudiante.Modificar(temp) ;

            Assert.IsTrue(db.Guardar(inscripcion));


        }

        [TestMethod()]
        public void Modficar()
        {
            RepositorioInscripcion db = new RepositorioInscripcion();

            List<InscripcionDetalles> lista = new List<InscripcionDetalles>();

            lista.Add(new InscripcionDetalles()
            {
                AsignaturaId = 1,
                //Asignatura = new Asignaturas() { AsignaturaId = 1 },
                InscripcionDetallesId = 1,
                InscripcionId = 1,
                SubTotal = 100
            });

            Inscripcion inscripcion = new Inscripcion()
            {
                InscripcionId = 1,
                EstudianteId = 1,
                Fecha = DateTime.Now,
                Asignaturas = lista
            };
            inscripcion.CalcularMonto();

            Assert.IsTrue(db.Modificar(inscripcion));

        }
        [TestMethod()]
        public void Eliminar()
        {
            RepositorioInscripcion db = new RepositorioInscripcion();

            Assert.IsTrue(db.Elimimar(1));

        }
    }
}
