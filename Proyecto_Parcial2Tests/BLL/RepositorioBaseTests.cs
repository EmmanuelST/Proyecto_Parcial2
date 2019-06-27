using Microsoft.VisualStudio.TestTools.UnitTesting;
using Proyecto_Parcial2.BLL;
using Proyecto_Parcial2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Parcial2.Entidades;

namespace Proyecto_Parcial2.BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
        [TestMethod()]
        public void GuardarAsignaturaTest()
        {
            Asignaturas entity = new Asignaturas()
            {
                AsignaturaId = 0,
                Creditos = 0,
                Descripcion = "Prueba1"
            };

            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();

            ;

            Assert.IsTrue(db.Guardar(entity));
        }

        [TestMethod()]
        public void GuardarEstudianteTest()
        {
            Estudiantes entity = new Estudiantes()
            {
                EstudianteId = 0,
                FechaIngreso = DateTime.Now,
                Balance = 0,
                Nombre = "Prueba1"
            };

            RepositorioBase<Estudiantes> db = new RepositorioBase<Estudiantes>();

            Assert.IsTrue(db.Guardar(entity));
        }

        [TestMethod()]
        public void ModificarAsignaturasTest()
        {
            
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();

            Asignaturas entity = new Asignaturas()
            {
                AsignaturaId = 1,
                Creditos = 0,
                Descripcion = "Prueba2"
            };

            Assert.IsTrue(db.Modificar(entity));
        }

        [TestMethod()]
        public void ModificarEstudianteTest()
        {

            RepositorioBase<Estudiantes> db = new RepositorioBase<Estudiantes>();

            Estudiantes entity = new Estudiantes()
            {
                EstudianteId = 1,
                FechaIngreso = DateTime.Now,
                Balance = 500,
                Nombre = "Prueba2"
            }; 
            

            Assert.IsTrue(db.Modificar(entity));
        }

        [TestMethod()]
        public void BuscarEstudianteTest()
        {

            RepositorioBase<Estudiantes> db = new RepositorioBase<Estudiantes>();

            
            Assert.IsNotNull(db.Buscar(1));
        }

        [TestMethod()]
        public void BuscarAsignaturaTest()
        {

            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();


            Assert.IsNotNull(db.Buscar(1));
        }

        [TestMethod()]
        public void GetListAsignaturaTest()
        {

            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();


            Assert.IsNotNull(db.GetList(E => true));
        }

        [TestMethod()]
        public void GetListEstudiantesTest()
        {

            RepositorioBase<Estudiantes> db = new RepositorioBase<Estudiantes>();


            Assert.IsNotNull(db.GetList(E => true));
        }

        [TestMethod()]
        public void EliminarEstudiantesTest()
        {

            RepositorioBase<Estudiantes> db = new RepositorioBase<Estudiantes>();


            Assert.IsNotNull(db.Elimimar(1));
        }

        [TestMethod()]
        public void EliminarAsignaturasTest()
        {

            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();


            Assert.IsNotNull(db.Elimimar(1));
        }
    }
}