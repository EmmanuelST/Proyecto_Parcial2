using Proyecto_Parcial2.DAL;
using Proyecto_Parcial2.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Parcial2.BLL
{
    public class RepositorioInscripcion : RepositorioBase<Inscripcion>
    {
        public override bool Guardar(Inscripcion entity)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                RepositorioBase<Estudiantes> dbE = new RepositorioBase<Estudiantes>();

                if(db.Inscripcion.Add(entity) != null)
                {
                    var estudiante = dbE.Buscar(entity.EstudianteId);
                    estudiante.Balance += entity.Monto;

                    paso = db.SaveChanges() > 0;
                    dbE.Modificar(estudiante);
                }

            }
            catch (Exception)
            {
                throw;
            }


            return paso;
        }

        public override bool Modificar(Inscripcion entity)
        {
            bool paso = false;
            Contexto db = new Contexto();
            RepositorioBase<Estudiantes> dbE = new RepositorioBase<Estudiantes>();
            decimal acumulador;
            acumulador = 0;

            try
            {
                var anterior = new RepositorioBase<Inscripcion>().Buscar(entity.InscripcionId);

                foreach(var item in anterior.Asiganturas)
                {
                    if (!entity.Asiganturas.Any(A => A.InscripcionDetallesId == item.InscripcionDetallesId))
                    {
                        db.Entry(item).State = EntityState.Deleted;
                      
                    }
                        
                }

                foreach(var item in entity.Asiganturas)
                {
                    if (item.InscripcionDetallesId == 0)
                    {
                        db.Entry(item).State = EntityState.Added;
                    }
                        
                    else
                        db.Entry(item).State = EntityState.Modified;
                }

                var estudiante = dbE.Buscar(entity.EstudianteId);


                db.Entry(entity).State = EntityState.Modified;

                paso = db.SaveChanges() > 0;


            }catch(Exception)
            {
                throw;
            }


            return paso;
        }

        public override bool Elimimar(int id)
        {

            bool paso = false;
            Contexto db = new Contexto();
            RepositorioBase<Estudiantes> dbE = new RepositorioBase<Estudiantes>();

            try
            {
                var eliminar = db.Inscripcion.Find(id);
                var estudiante = dbE.Buscar(eliminar.EstudianteId);

                estudiante.Balance -= eliminar.Monto;
                //dbE.Modificar(estudiante);

                db.Entry(eliminar).State = EntityState.Deleted;
                paso = db.SaveChanges() > 0;


            }catch(Exception)
            {
                throw;
            }

            return paso;
        }

    }
}
