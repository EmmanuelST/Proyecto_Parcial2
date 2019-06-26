﻿using Proyecto_Parcial2.DAL;
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

        public override bool Modificar(Inscripcion entity)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var anterior = new RepositorioBase<Inscripcion>().Buscar(entity.InscripcionId);

                foreach(var item in anterior.Asiganturas)
                {
                    if (!entity.Asiganturas.Any(A => A.InscripcionDetallesId == item.InscripcionDetallesId))
                        db.Entry(item).State = EntityState.Deleted;
                }

                foreach(var item in entity.Asiganturas)
                {
                    if (item.InscripcionDetallesId == 0)
                        db.Entry(item).State = EntityState.Added;
                    else
                        db.Entry(item).State = EntityState.Modified;
                }

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

            try
            {
                var eliminar = db.Inscripcion.Find(id);
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