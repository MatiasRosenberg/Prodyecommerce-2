
namespace ProdyEcommercefull
{
    partial class Subrubros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Subrubros));
            this.txtnombrebus = new System.Windows.Forms.TextBox();
            this.txtidsubrubrobus = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btngrabar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.dgvsubrubros = new System.Windows.Forms.DataGridView();
            this.cbpublicar = new System.Windows.Forms.CheckBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtidsubrubro = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsubrubros)).BeginInit();
            this.SuspendLayout();
            // 
            // txtnombrebus
            // 
            this.txtnombrebus.Location = new System.Drawing.Point(208, 123);
            this.txtnombrebus.Name = "txtnombrebus";
            this.txtnombrebus.Size = new System.Drawing.Size(338, 20);
            this.txtnombrebus.TabIndex = 25;
            this.txtnombrebus.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtnombrebus_KeyUp);
            // 
            // txtidsubrubrobus
            // 
            this.txtidsubrubrobus.Location = new System.Drawing.Point(12, 123);
            this.txtidsubrubrobus.Name = "txtidsubrubrobus";
            this.txtidsubrubrobus.Size = new System.Drawing.Size(190, 20);
            this.txtidsubrubrobus.TabIndex = 24;
            this.txtidsubrubrobus.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtidsubrubrobus_KeyUp);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(471, 270);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 30);
            this.btnsalir.TabIndex = 23;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Enabled = false;
            this.btnlimpiar.Location = new System.Drawing.Point(357, 270);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 30);
            this.btnlimpiar.TabIndex = 22;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btngrabar
            // 
            this.btngrabar.Enabled = false;
            this.btngrabar.Location = new System.Drawing.Point(243, 270);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(75, 30);
            this.btngrabar.TabIndex = 21;
            this.btngrabar.Text = "Grabar";
            this.btngrabar.UseVisualStyleBackColor = true;
            this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(129, 270);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 30);
            this.btnmodificar.TabIndex = 20;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(15, 270);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 30);
            this.btnnuevo.TabIndex = 19;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // dgvsubrubros
            // 
            this.dgvsubrubros.AllowUserToAddRows = false;
            this.dgvsubrubros.AllowUserToDeleteRows = false;
            this.dgvsubrubros.AllowUserToOrderColumns = true;
            this.dgvsubrubros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsubrubros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsubrubros.Location = new System.Drawing.Point(12, 149);
            this.dgvsubrubros.Name = "dgvsubrubros";
            this.dgvsubrubros.ReadOnly = true;
            this.dgvsubrubros.Size = new System.Drawing.Size(535, 115);
            this.dgvsubrubros.TabIndex = 18;
            this.dgvsubrubros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsubrubros_CellClick);
            this.dgvsubrubros.SelectionChanged += new System.EventHandler(this.dgvsubrubros_SelectionChanged);
            // 
            // cbpublicar
            // 
            this.cbpublicar.AutoSize = true;
            this.cbpublicar.Enabled = false;
            this.cbpublicar.Location = new System.Drawing.Point(90, 78);
            this.cbpublicar.Name = "cbpublicar";
            this.cbpublicar.Size = new System.Drawing.Size(87, 17);
            this.cbpublicar.TabIndex = 17;
            this.cbpublicar.Text = "Publicar web";
            this.cbpublicar.UseVisualStyleBackColor = true;
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(90, 51);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(180, 20);
            this.txtnombre.TabIndex = 16;
            // 
            // txtidsubrubro
            // 
            this.txtidsubrubro.Enabled = false;
            this.txtidsubrubro.Location = new System.Drawing.Point(90, 18);
            this.txtidsubrubro.MaxLength = 4;
            this.txtidsubrubro.Name = "txtidsubrubro";
            this.txtidsubrubro.Size = new System.Drawing.Size(103, 20);
            this.txtidsubrubro.TabIndex = 15;
            this.txtidsubrubro.Leave += new System.EventHandler(this.txtidsubrubro_Leave);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(12, 52);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(67, 16);
            this.lblnombre.TabIndex = 14;
            this.lblnombre.Text = "Nombre:";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(12, 19);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(62, 16);
            this.lblcodigo.TabIndex = 13;
            this.lblcodigo.Text = "Codigo:";
            // 
            // Subrubros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 318);
            this.Controls.Add(this.txtnombrebus);
            this.Controls.Add(this.txtidsubrubrobus);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btngrabar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.dgvsubrubros);
            this.Controls.Add(this.cbpublicar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtidsubrubro);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblcodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Subrubros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subrubros";
            this.Load += new System.EventHandler(this.Subrubros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsubrubros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombrebus;
        private System.Windows.Forms.TextBox txtidsubrubrobus;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.DataGridView dgvsubrubros;
        private System.Windows.Forms.CheckBox cbpublicar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtidsubrubro;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblcodigo;
    }
}