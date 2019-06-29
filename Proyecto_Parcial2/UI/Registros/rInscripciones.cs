﻿using Proyecto_Parcial2.BLL;
using Proyecto_Parcial2.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Parcial2.UI
{
    public partial class rInscripciones : Form
    {
        private List<InscripcionDetalles> Detalles;
        public rInscripciones()
        {
            InitializeComponent();
            Detalles = new List<InscripcionDetalles>();
        }

       
        private void BuscarInscripcionbutton_Click(object sender, EventArgs e)
        {
           

            errorProvider.Clear();
            RepositorioInscripcion db = new RepositorioInscripcion();
            Inscripcion inscripcion = new Inscripcion();

            try
            {
                if(IdInscripcionnumericUpDown.Value > 0)
                {

                    if ((inscripcion = db.Buscar((int)IdInscripcionnumericUpDown.Value)) != null)
                    {
                        Limpiar();
                        LlenarCampos(inscripcion);
                        LlenarCamposEstudiante(BuscarEstudiante(inscripcion.EstudianteId));

                    }
                    else
                    {
                        MessageBox.Show("No se pudo encontrar","Atencion!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                    }

                }
                else
                {
                    errorProvider.SetError(IdInscripcionnumericUpDown,"Este campo no puede ser cero para buscar");
                }

            }catch(Exception)
            {
                throw;
                //MessageBox.Show("Ocurrio un error!!","Erro!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            
        }

        private void Limpiar()
        {

            IdInscripcionnumericUpDown.Value = 0;
            IdEstudiantenumericUpDown.Value = 0;
            EstudianteNombretextBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;
            IdAsignaturanumericUpDown.Value = 0;
            DescripcionAsignaturatextBox.Text = string.Empty;
            Detalles = new List<InscripcionDetalles>();
            CargarGrip();
            TotaltextBox.Text = "0";

        }

        private Inscripcion LlenarInscripcion()
        {
            Inscripcion inscripcion = new Inscripcion();

            inscripcion.InscripcionId = (int)IdInscripcionnumericUpDown.Value;
            inscripcion.EstudianteId = (int)IdEstudiantenumericUpDown.Value;
            inscripcion.Fecha = FechadateTimePicker.Value;
            inscripcion.Asiganturas = Detalles;
            inscripcion.CalcularMonto();

            return inscripcion;

        }
        private bool Validar()
        {

            errorProvider.Clear();
            bool paso = true;

            if(IdEstudiantenumericUpDown.Value == 0)
            {
                errorProvider.SetError(IdEstudiantenumericUpDown,"Se debe seleccionar un estudiante");
                paso = false;
            }

            if(string.IsNullOrWhiteSpace(EstudianteNombretextBox.Text))
            {
                errorProvider.SetError(EstudianteNombretextBox,"Este campo no puede estar vacio");
                paso = false;

            }
            
            if(Detalles.Count == 0)
            {
                errorProvider.SetError(AsignaturasdataGridView,"Debe inscribir almenos una asignatura");
                paso = false;
            }

            return paso;

        }

        private void LlenarCampos(Inscripcion inscripcion)
        {
            IdInscripcionnumericUpDown.Value = inscripcion.InscripcionId;
            IdEstudiantenumericUpDown.Value = inscripcion.EstudianteId;
            FechadateTimePicker.Value = inscripcion.Fecha;
            inscripcion.CalcularMonto();
            TotaltextBox.Text = inscripcion.Monto.ToString();
            Detalles = new List<InscripcionDetalles>();
            Detalles = inscripcion.Asiganturas;
            CargarGrip();

        }

        private void LlenarCamposEstudiante(Estudiantes estudiante)
        {
            IdEstudiantenumericUpDown.Value = estudiante.EstudianteId;
            EstudianteNombretextBox.Text = estudiante.Nombre;
        }

        private Estudiantes BuscarEstudiante(int id)
        {
            RepositorioBase<Estudiantes> db = new RepositorioBase<Estudiantes>();
            Estudiantes estudiante = new Estudiantes();
            try
            {
                estudiante = db.Buscar(id);


            }catch(Exception)
            {
                throw;
            }

            return estudiante;
        }

        private Asignaturas BuscarAsigantura(int id)
        {
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();
            Asignaturas asignatura;

            try
            {
                asignatura = db.Buscar(id);

            }catch(Exception)
            {
                throw;

            }


            return asignatura;
        }

        private void CargarGrip()
        {
            AsignaturasdataGridView.DataSource = null;
            AsignaturasdataGridView.DataSource = Detalles;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

            if (!Validar())
                return;

            RepositorioInscripcion db = new RepositorioInscripcion();
            Inscripcion inscripcion = LlenarInscripcion();


            try
            {
                inscripcion.CalcularMonto();
                if (IdInscripcionnumericUpDown.Value == 0)
                {
                    if (db.Guardar(inscripcion))
                    {
                        Limpiar();
                        MessageBox.Show("Guardado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                }
                else
                {
                    if(db.Modificar(inscripcion))
                    {
                        Limpiar();
                        MessageBox.Show("Modificado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }


            }catch(Exception)
            {
                throw;
                //MessageBox.Show("Hubo un error", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositorioInscripcion db = new RepositorioInscripcion();

            int id = (int)IdInscripcionnumericUpDown.Value;

            db.Elimimar(id);

            /*try
            {

                if(IdInscripcionnumericUpDown.Value > 0)
                {
                    db.Elimimar((int)IdInscripcionnumericUpDown.Value);
                }
                else
                {
                    errorProvider.SetError(IdInscripcionnumericUpDown,"Este campo no puede ser cero para eliminar");
                }

            }catch(Exception)
            {
                throw;
                //MessageBox.Show("No se puede eliminar si no existe","Atencion!!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }*/
        }

        private void BuscarEstudiantebutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> db = new RepositorioBase<Estudiantes>();
            Estudiantes estudiante;

            try
            {
               if(IdEstudiantenumericUpDown.Value > 0)
               {
                    if((estudiante = db.Buscar((int)IdEstudiantenumericUpDown.Value)) != null)
                    {
                        LlenarCamposEstudiante(estudiante);
                        
                    }
                    else
                    {
                        MessageBox.Show("No se encontro el estudiante","Atencion!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
               }
               else
               {
                    errorProvider.SetError(IdEstudiantenumericUpDown,"Este campo no puede ser cero");
               }


            }catch(Exception)
            {
                throw;
                //MessageBox.Show("Ocurrio un error","Erro!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        

        private void BuscarAsignaturabutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();
            Asignaturas asignatura;

            try
            {
                if(IdAsignaturanumericUpDown.Value > 0)
                {
                    if((asignatura = db.Buscar((int)IdAsignaturanumericUpDown.Value))!= null)
                    {
                        DescripcionAsignaturatextBox.Text = asignatura.Descripcion;

                    }
                    else
                    {
                        MessageBox.Show("NO se pudo encontrar","Atencion!!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    errorProvider.SetError(IdAsignaturanumericUpDown,"Este campo no puede ser cero");
                }
            }catch(Exception)
            {
                throw;
                //MessageBox.Show("Ocurrio un error","Error!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private bool ValidarAddAsignatura()
        {
            bool paso = true;

            if (PrecioCreditosnumericUpDown.Value <= 0)
            {
                errorProvider.SetError(PrecioCreditosnumericUpDown, "Debe fijar el precio de los creditos");
                paso = false;
            }

            if(string.IsNullOrWhiteSpace(DescripcionAsignaturatextBox.Text))
            {
                errorProvider.SetError(DescripcionAsignaturatextBox, "Este campo no puede estar vacio, busque una asignatura");
                paso = false;
            }


            return paso;
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            try
            {
                if (IdAsignaturanumericUpDown.Value > 0)
                {


                    if (!ValidarAddAsignatura())
                        return;


                    Asignaturas asignatura;
                    if ( (asignatura = BuscarAsigantura((int)IdAsignaturanumericUpDown.Value)) != null)
                    {
                        Detalles.Add(new InscripcionDetalles()
                        {
                            InscripcionId = (int)IdInscripcionnumericUpDown.Value,
                            AsignaturaId = asignatura.AsignaturaId,
                            //Asignatura = asignatura,
                            InscripcionDetallesId = 0,
                            SubTotal = (asignatura.Creditos * PrecioCreditosnumericUpDown.Value)
                        });
                        CargarGrip();
                    }
                    else
                    {
                        MessageBox.Show("NO se pudo encontrar la asignatura", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else
                {
                    errorProvider.SetError(IdAsignaturanumericUpDown, "Este valor no puede ser cero");
                }
            }
            catch(Exception)
            {
                throw;
                //MessageBox.Show("Ocurrio un error","Error!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void EliminarFilabutton_Click(object sender, EventArgs e)
        {
            try
            {
                Detalles.RemoveAt(AsignaturasdataGridView.CurrentRow.Index);
                CargarGrip();
            }
            catch(Exception)
            {
                
            }
           
        }
    }
}
