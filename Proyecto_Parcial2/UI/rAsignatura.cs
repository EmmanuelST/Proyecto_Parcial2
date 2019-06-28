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
    public partial class rAsignatura : Form
    {
        public rAsignatura()
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
            DescripciontextBox.Text = string.Empty;
            CreditosnumericUpDown.Value = 0;

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {

            if (!Validar())
                return;

            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();
            Asignaturas asigantura = new Asignaturas();
            asigantura = LlenarClase();

            try
            {

                if (IdnumericUpDown.Value == 0)
                {
                    if (db.Guardar(asigantura))
                    {
                        Limpiar();
                        MessageBox.Show("Guardado correctamente", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo guardar", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    if(db.Modificar(asigantura))
                    {
                        Limpiar();
                        MessageBox.Show("Modificado correctamente", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo moficar", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            catch(Exception)
            {
                MessageBox.Show("Hubo un error", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            


        }

        private bool Validar()
        {
            bool paso = true;
            errorProvider.Clear();

            if(string.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                errorProvider.SetError(DescripciontextBox,"Este campo no puede estar vacio");
                paso = false;
            }

            if(CreditosnumericUpDown.Value == 0)
            {
                errorProvider.SetError(CreditosnumericUpDown,"Los creditos no pueden ser cero");
                paso = false;

            }

            if(CreditosnumericUpDown.Value > 5)
            {
                errorProvider.SetError(CreditosnumericUpDown,"Una Asignatura no puede tener mas de 5 creditos");
                paso = false;

            }


            return paso;
        }

        private void LlenarCampos(Asignaturas asignatura)
        {
            IdnumericUpDown.Value = asignatura.AsignaturaId;
            DescripciontextBox.Text = asignatura.Descripcion;
            CreditosnumericUpDown.Value = asignatura.Creditos;

        }

        private Asignaturas LlenarClase()
        {
            Asignaturas asignatura = new Asignaturas();

            asignatura.AsignaturaId = (int)IdnumericUpDown.Value;
            asignatura.Descripcion = DescripciontextBox.Text;
            asignatura.Creditos = (int)CreditosnumericUpDown.Value;

            return asignatura;

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();
            
            try
            {
                if(IdnumericUpDown.Value > 0)
                {
                    if(db.Elimimar((int)IdnumericUpDown.Value))
                    {
                        Limpiar();
                        MessageBox.Show("Eliminado correctamente","Atencion!!",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    errorProvider.SetError(IdnumericUpDown,"Este campo no puede ser cero");
;               }


            }catch(Exception)
            {
                MessageBox.Show("Hubo un error", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> db = new RepositorioBase<Asignaturas>();
            Asignaturas asignatura;

            try
            {

                if(IdnumericUpDown.Value > 0)
                {
                    if((asignatura = db.Buscar((int)IdnumericUpDown.Value)) != null)
                    {
                        Limpiar();
                        LlenarCampos(asignatura);
                    }
                    else
                    {
                        MessageBox.Show("No se encontro la asignatura","Atencion!!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }

                }
                else
                {
                    errorProvider.SetError(IdnumericUpDown,"Este campo no puede ser cero");
                }


            }catch(Exception)
            {
                MessageBox.Show("Hubo un error", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
