﻿using System;
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
    }
}