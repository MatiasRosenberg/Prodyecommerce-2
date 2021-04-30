﻿using System;
using System.Windows.Forms;

namespace ProdyEcommerce
{
    partial class Busqueda_avanzada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Busqueda_avanzada));
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.lblbusqueda = new System.Windows.Forms.Label();
            this.lblfiltro = new System.Windows.Forms.Label();
            this.comboboxfiltro = new System.Windows.Forms.ComboBox();
            this.dgvarticulos = new System.Windows.Forms.DataGridView();
            this.btnbuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvarticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtbusqueda.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtbusqueda.Location = new System.Drawing.Point(73, 12);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(429, 20);
            this.txtbusqueda.TabIndex = 0;
            // 
            // lblbusqueda
            // 
            this.lblbusqueda.AutoSize = true;
            this.lblbusqueda.Location = new System.Drawing.Point(9, 15);
            this.lblbusqueda.Name = "lblbusqueda";
            this.lblbusqueda.Size = new System.Drawing.Size(55, 13);
            this.lblbusqueda.TabIndex = 1;
            this.lblbusqueda.Text = "Busqueda";
            // 
            // lblfiltro
            // 
            this.lblfiltro.AutoSize = true;
            this.lblfiltro.Location = new System.Drawing.Point(729, 16);
            this.lblfiltro.Name = "lblfiltro";
            this.lblfiltro.Size = new System.Drawing.Size(53, 13);
            this.lblfiltro.TabIndex = 2;
            this.lblfiltro.Text = "Filtrar por:";
            // 
            // comboboxfiltro
            // 
            this.comboboxfiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxfiltro.FormattingEnabled = true;
            this.comboboxfiltro.Location = new System.Drawing.Point(789, 11);
            this.comboboxfiltro.Name = "comboboxfiltro";
            this.comboboxfiltro.Size = new System.Drawing.Size(150, 21);
            this.comboboxfiltro.TabIndex = 3;
            // 
            // dgvarticulos
            // 
            this.dgvarticulos.AllowUserToAddRows = false;
            this.dgvarticulos.AllowUserToDeleteRows = false;
            this.dgvarticulos.AllowUserToOrderColumns = true;
            this.dgvarticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvarticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvarticulos.Location = new System.Drawing.Point(12, 52);
            this.dgvarticulos.Name = "dgvarticulos";
            this.dgvarticulos.ReadOnly = true;
            this.dgvarticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvarticulos.Size = new System.Drawing.Size(961, 287);
            this.dgvarticulos.TabIndex = 4;
            this.dgvarticulos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvarticulos_CellClick);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(509, 12);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(90, 21);
            this.btnbuscar.TabIndex = 5;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // Busqueda_avanzada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 388);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.dgvarticulos);
            this.Controls.Add(this.comboboxfiltro);
            this.Controls.Add(this.lblfiltro);
            this.Controls.Add(this.lblbusqueda);
            this.Controls.Add(this.txtbusqueda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Busqueda_avanzada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda_avanzada";
            this.Load += new System.EventHandler(this.Busqueda_avanzada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvarticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dgvarticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion
        private System.Windows.Forms.Label lblbusqueda;
        private System.Windows.Forms.Label lblfiltro;
        private System.Windows.Forms.Button btnbuscar;
        public System.Windows.Forms.TextBox txtbusqueda;
        public DataGridView dgvarticulos;
        private ComboBox comboboxfiltro;
    }
}