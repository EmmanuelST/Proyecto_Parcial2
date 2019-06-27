using Proyecto_Parcial2.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Parcial2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void RegistroDeEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEstudiante registro = new rEstudiante();
            registro.MdiParent = this;
            registro.Show();
        }
    }
}
