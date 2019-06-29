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

namespace Proyecto_Parcial2.UI.Consultas
{
    public partial class cEstudiantes : Form
    {
        public cEstudiantes()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {

        }

        private void Buscar()
        {
            var listado = new List<Estudiantes>();
            RepositorioBase<Estudiantes> db = new RepositorioBase<Estudiantes>();

            if (CriteriotextBox.Text.Trim().Length > 0)
            {

                try
                {
                    switch (FiltrocomboBox.SelectedIndex)
                    {
                        case 0://Todo
                            listado = db.GetList(A => true);
                            break;

                        case 1://ID
                            int id = Convert.ToInt32(CriteriotextBox.Text);
                            listado = db.GetList(E => E.EstudianteId == id);
                            break;

                        case 2://Nombre
                            listado = db.GetList(E => E.Nombre.Contains(CriteriotextBox.Text));
                            break;

                    }
                }
                catch (Exception)
                {

                }

            }
            else
            {
                listado = db.GetList(p => true);
            }

            listado = listado.Where(E => E.FechaIngreso >= DesdedateTimePicker.Value && E.FechaIngreso <= HastadateTimePicker.Value ).ToList();

            ConsultadataGridView.DataSource = null;
            ConsultadataGridView.DataSource = listado;
        }
    }
}
