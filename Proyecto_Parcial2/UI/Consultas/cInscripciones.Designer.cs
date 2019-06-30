﻿namespace Proyecto_Parcial2.UI.Consultas
{
    partial class cInscripciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cInscripciones));
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.DesdedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.ConsultadataGridView = new System.Windows.Forms.DataGridView();
            this.CriteriotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Items.AddRange(new object[] {
            "Todo",
            "InscripcionId",
            "EstudianteId"});
            this.FiltrocomboBox.Location = new System.Drawing.Point(335, 13);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(178, 21);
            this.FiltrocomboBox.TabIndex = 32;
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(193, 13);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.HastadateTimePicker.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Hasta:";
            // 
            // DesdedateTimePicker
            // 
            this.DesdedateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.DesdedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdedateTimePicker.Location = new System.Drawing.Point(50, 12);
            this.DesdedateTimePicker.Name = "DesdedateTimePicker";
            this.DesdedateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.DesdedateTimePicker.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Desde:";
            // 
            // ConsultadataGridView
            // 
            this.ConsultadataGridView.AllowUserToAddRows = false;
            this.ConsultadataGridView.AllowUserToDeleteRows = false;
            this.ConsultadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultadataGridView.Location = new System.Drawing.Point(12, 40);
            this.ConsultadataGridView.Name = "ConsultadataGridView";
            this.ConsultadataGridView.ReadOnly = true;
            this.ConsultadataGridView.Size = new System.Drawing.Size(822, 403);
            this.ConsultadataGridView.TabIndex = 27;
            // 
            // CriteriotextBox
            // 
            this.CriteriotextBox.Location = new System.Drawing.Point(561, 13);
            this.CriteriotextBox.Name = "CriteriotextBox";
            this.CriteriotextBox.Size = new System.Drawing.Size(193, 20);
            this.CriteriotextBox.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Criterio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Filtro:";
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::Proyecto_Parcial2.Properties.Resources.buscaTyni;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(759, 11);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 23);
            this.Buscarbutton.TabIndex = 26;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // cInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.Controls.Add(this.FiltrocomboBox);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DesdedateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ConsultadataGridView);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.CriteriotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cInscripciones";
            this.Text = "Consulta de Inscripciones";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultadataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView ConsultadataGridView;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox CriteriotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}