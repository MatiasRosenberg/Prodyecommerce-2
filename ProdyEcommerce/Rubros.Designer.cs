
namespace ProdyEcommercefull
{
    partial class Rurbos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rurbos));
            this.lblcodigo = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txtidrubro = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.cbpublicar = new System.Windows.Forms.CheckBox();
            this.dgvrubros = new System.Windows.Forms.DataGridView();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btngrabar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.txtidrubrobus = new System.Windows.Forms.TextBox();
            this.txtnombrebus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvrubros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(12, 21);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(62, 16);
            this.lblcodigo.TabIndex = 0;
            this.lblcodigo.Text = "Codigo:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(12, 54);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(67, 16);
            this.lblnombre.TabIndex = 1;
            this.lblnombre.Text = "Nombre:";
            // 
            // txtidrubro
            // 
            this.txtidrubro.Enabled = false;
            this.txtidrubro.Location = new System.Drawing.Point(90, 20);
            this.txtidrubro.Name = "txtidrubro";
            this.txtidrubro.Size = new System.Drawing.Size(103, 20);
            this.txtidrubro.TabIndex = 2;
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(90, 53);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(180, 20);
            this.txtnombre.TabIndex = 3;
            // 
            // cbpublicar
            // 
            this.cbpublicar.AutoSize = true;
            this.cbpublicar.Location = new System.Drawing.Point(90, 80);
            this.cbpublicar.Name = "cbpublicar";
            this.cbpublicar.Size = new System.Drawing.Size(87, 17);
            this.cbpublicar.TabIndex = 4;
            this.cbpublicar.Text = "Publicar web";
            this.cbpublicar.UseVisualStyleBackColor = true;
            // 
            // dgvrubros
            // 
            this.dgvrubros.AllowUserToAddRows = false;
            this.dgvrubros.AllowUserToDeleteRows = false;
            this.dgvrubros.AllowUserToOrderColumns = true;
            this.dgvrubros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvrubros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvrubros.Location = new System.Drawing.Point(12, 151);
            this.dgvrubros.Name = "dgvrubros";
            this.dgvrubros.ReadOnly = true;
            this.dgvrubros.Size = new System.Drawing.Size(535, 115);
            this.dgvrubros.TabIndex = 5;
            this.dgvrubros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvrubros_CellClick);
            this.dgvrubros.SelectionChanged += new System.EventHandler(this.dgvrubros_SelectionChanged);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(15, 272);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 30);
            this.btnnuevo.TabIndex = 6;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(129, 272);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(75, 30);
            this.btnmodificar.TabIndex = 7;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            // 
            // btngrabar
            // 
            this.btngrabar.Enabled = false;
            this.btngrabar.Location = new System.Drawing.Point(243, 272);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(75, 30);
            this.btngrabar.TabIndex = 8;
            this.btngrabar.Text = "Grabar";
            this.btngrabar.UseVisualStyleBackColor = true;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Enabled = false;
            this.btnlimpiar.Location = new System.Drawing.Point(357, 272);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 30);
            this.btnlimpiar.TabIndex = 9;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(471, 272);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 30);
            this.btnsalir.TabIndex = 10;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // txtidrubrobus
            // 
            this.txtidrubrobus.Location = new System.Drawing.Point(12, 125);
            this.txtidrubrobus.Name = "txtidrubrobus";
            this.txtidrubrobus.Size = new System.Drawing.Size(190, 20);
            this.txtidrubrobus.TabIndex = 11;
            this.txtidrubrobus.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtidrubrobus_KeyUp);
            // 
            // txtnombrebus
            // 
            this.txtnombrebus.Location = new System.Drawing.Point(208, 125);
            this.txtnombrebus.Name = "txtnombrebus";
            this.txtnombrebus.Size = new System.Drawing.Size(338, 20);
            this.txtnombrebus.TabIndex = 12;
            this.txtnombrebus.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtnombrebus_KeyUp);
            // 
            // Rurbos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 326);
            this.Controls.Add(this.txtnombrebus);
            this.Controls.Add(this.txtidrubrobus);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btngrabar);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.dgvrubros);
            this.Controls.Add(this.cbpublicar);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtidrubro);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblcodigo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Rurbos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rubros";
            this.Load += new System.EventHandler(this.Rurbos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvrubros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcodigo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtidrubro;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.CheckBox cbpublicar;
        private System.Windows.Forms.DataGridView dgvrubros;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.TextBox txtidrubrobus;
        private System.Windows.Forms.TextBox txtnombrebus;
    }
}