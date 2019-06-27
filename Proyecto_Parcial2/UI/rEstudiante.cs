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
    public partial class rEstudiante : Form
    {
        public rEstudiante()
        {
            InitializeComponent();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            NombretextBox.Text = string.Empty;
            FechadateTimePicker.Value = DateTime.Now;
            BalancetextBox.Text = "0";

        }

        private void Guadarbutton_Click(object sender, EventArgs e)
        {

            if (!validar())
                return;

            try
            {
                Estudiantes estudiante = new Estudiantes();
                estudiante = LlenarClase();
                RepositorioBase<Estudiantes> db = new RepositorioBase<Estudiantes>();

                if (IdnumericUpDown.Value == 0)
                {
                    db.Guardar(estudiante);
                    MessageBox.Show("Guardado Correctamente","Atencion!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    db.Modificar(estudiante);
                    MessageBox.Show("Modificado Correctamente", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }catch(Exception)
            {
                MessageBox.Show("Hubo un error", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool validar()
        {
            bool paso = true;
            errorProvider.Clear();

            if(string.IsNullOrWhiteSpace(NombretextBox.Text))
            {
                errorProvider.SetError(NombretextBox, "Este campo no puede estar vacio");
                paso = false;
            }

            if(FechadateTimePicker.Value > DateTime.Now)
            {
                errorProvider.SetError(FechadateTimePicker,"La fecha no puede ser mayor que la de hoy");
                paso = false;
            }

            return paso;
        }

        private Estudiantes LlenarClase()
        {
            Estudiantes estudiante = new Estudiantes();

            estudiante.Nombres = NombretextBox.Text;
            estudiante.EstudianteId = (int)IdnumericUpDown.Value;
            estudiante.FechaIngreso = FechadateTimePicker.Value;
            estudiante.Balance = Decimal.Parse(BalancetextBox.Text);
            
            return estudiante;
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> db = new RepositorioBase<Estudiantes>();

            try
            {
                if (IdnumericUpDown.Value > 0)
                {
                    if (db.Elimimar((int)IdnumericUpDown.Value))
                    {
                        MessageBox.Show("Eliminado Correctamente", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No se puede eliminar", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        
                    }
                        
                }
               
                
            }catch(Exception)
            {
                MessageBox.Show("Hubo un error eliminando", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
