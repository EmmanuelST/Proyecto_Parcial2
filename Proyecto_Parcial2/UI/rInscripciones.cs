using Proyecto_Parcial2.BLL;
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
            CargarAsignaturas();
        }

        private void CargarAsignaturas()
        {
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();

            try
            {
                AsiganaturascomboBox.DataSource = null;
                AsiganaturascomboBox.DataSource = db.GetList(p => true);
                AsiganaturascomboBox.ValueMember = "AsignaturaId";
                AsiganaturascomboBox.DisplayMember = "Descripcion";


            }catch(Exception)
            {
                MessageBox.Show("Hubo un error al cargar las Asignaturas","Erro!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        

        

        private void BuscarInscripcionbutton_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;

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
            }

            
        }

        private void Limpiar()
        {

            IdInscripcionnumericUpDown.Value = 0;
            CargarAsignaturas();
            FechadateTimePicker.Value = DateTime.Now;
            Detalles = new List<InscripcionDetalles>();
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
            LLenarEstudiante(inscripcion.EstudianteId);
            Detalles = inscripcion.Asiganturas;
            CargarGrip();

        }

        private void CargarGrip()
        {
            AsignaturasdataGridView.DataSource = null;
            AsignaturasdataGridView.DataSource = Detalles;
        }
    }
}
