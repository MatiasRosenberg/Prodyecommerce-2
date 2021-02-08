namespace ProdyEcommerce
{
    partial class Productos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btngrabar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label = new System.Windows.Forms.TabPage();
            this.cmbsubrubro = new System.Windows.Forms.ComboBox();
            this.cmbrubro = new System.Windows.Forms.ComboBox();
            this.txtbuscod = new System.Windows.Forms.TextBox();
            this.txtbusnom = new System.Windows.Forms.TextBox();
            this.dtgridcodigo = new System.Windows.Forms.DataGridView();
            this.txtumedida = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtancho = new System.Windows.Forms.TextBox();
            this.txtalto = new System.Windows.Forms.TextBox();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.txtcodigoequiv = new System.Windows.Forms.TextBox();
            this.lblancho = new System.Windows.Forms.Label();
            this.lblalto = new System.Windows.Forms.Label();
            this.lblpeso = new System.Windows.Forms.Label();
            this.lblstock = new System.Windows.Forms.Label();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblcodigoequiv = new System.Windows.Forms.Label();
            this.lblmedida = new System.Windows.Forms.Label();
            this.lblsubrubro = new System.Windows.Forms.Label();
            this.lblrubro = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcodigo = new System.Windows.Forms.Label();
            this.txtnombrecod = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chkinhabilitar = new System.Windows.Forms.CheckBox();
            this.btnsyncp = new System.Windows.Forms.Button();
            this.lblagrupacion = new System.Windows.Forms.Label();
            this.txtlistart = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Cbpvariable = new System.Windows.Forms.CheckBox();
            this.Cbpagrupado = new System.Windows.Forms.CheckBox();
            this.CBPulicar = new System.Windows.Forms.CheckBox();
            this.lbltags = new System.Windows.Forms.Label();
            this.txttags = new System.Windows.Forms.TextBox();
            this.lblRubrosEco = new System.Windows.Forms.Label();
            this.chkrubros = new System.Windows.Forms.CheckedListBox();
            this.txtdetalles = new System.Windows.Forms.TextBox();
            this.lbldetalle = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtarticulo = new System.Windows.Forms.TextBox();
            this.lblarticulo = new System.Windows.Forms.Label();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.label.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridcodigo)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btngrabar
            // 
            this.btngrabar.BackColor = System.Drawing.Color.LightBlue;
            this.btngrabar.Location = new System.Drawing.Point(503, 635);
            this.btngrabar.Name = "btngrabar";
            this.btngrabar.Size = new System.Drawing.Size(87, 32);
            this.btngrabar.TabIndex = 16;
            this.btngrabar.Text = "&Grabar";
            this.btngrabar.UseVisualStyleBackColor = true;
            this.btngrabar.Click += new System.EventHandler(this.btngrabar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.LightBlue;
            this.btnsalir.Location = new System.Drawing.Point(689, 634);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(87, 32);
            this.btnsalir.TabIndex = 18;
            this.btnsalir.Text = "&Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.label);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(959, 616);
            this.tabControl1.TabIndex = 23;
            // 
            // label
            // 
            this.label.Controls.Add(this.cmbsubrubro);
            this.label.Controls.Add(this.cmbrubro);
            this.label.Controls.Add(this.txtbuscod);
            this.label.Controls.Add(this.txtbusnom);
            this.label.Controls.Add(this.dtgridcodigo);
            this.label.Controls.Add(this.txtumedida);
            this.label.Controls.Add(this.txtprecio);
            this.label.Controls.Add(this.txtancho);
            this.label.Controls.Add(this.txtalto);
            this.label.Controls.Add(this.txtpeso);
            this.label.Controls.Add(this.txtstock);
            this.label.Controls.Add(this.txtcodigoequiv);
            this.label.Controls.Add(this.lblancho);
            this.label.Controls.Add(this.lblalto);
            this.label.Controls.Add(this.lblpeso);
            this.label.Controls.Add(this.lblstock);
            this.label.Controls.Add(this.lblprecio);
            this.label.Controls.Add(this.lblcodigoequiv);
            this.label.Controls.Add(this.lblmedida);
            this.label.Controls.Add(this.lblsubrubro);
            this.label.Controls.Add(this.lblrubro);
            this.label.Controls.Add(this.lblnombre);
            this.label.Controls.Add(this.lblcodigo);
            this.label.Controls.Add(this.txtnombrecod);
            this.label.Controls.Add(this.txtcodigo);
            this.label.Location = new System.Drawing.Point(4, 22);
            this.label.Name = "label";
            this.label.Padding = new System.Windows.Forms.Padding(3);
            this.label.Size = new System.Drawing.Size(951, 590);
            this.label.TabIndex = 0;
            this.label.Text = "Datos basicos ";
            this.label.UseVisualStyleBackColor = true;
            // 
            // cmbsubrubro
            // 
            this.cmbsubrubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsubrubro.FormattingEnabled = true;
            this.cmbsubrubro.Location = new System.Drawing.Point(88, 89);
            this.cmbsubrubro.Name = "cmbsubrubro";
            this.cmbsubrubro.Size = new System.Drawing.Size(187, 21);
            this.cmbsubrubro.TabIndex = 5;
            // 
            // cmbrubro
            // 
            this.cmbrubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbrubro.FormattingEnabled = true;
            this.cmbrubro.Location = new System.Drawing.Point(88, 61);
            this.cmbrubro.Name = "cmbrubro";
            this.cmbrubro.Size = new System.Drawing.Size(187, 21);
            this.cmbrubro.TabIndex = 4;
            // 
            // txtbuscod
            // 
            this.txtbuscod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtbuscod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtbuscod.Location = new System.Drawing.Point(9, 279);
            this.txtbuscod.MaxLength = 50;
            this.txtbuscod.Name = "txtbuscod";
            this.txtbuscod.Size = new System.Drawing.Size(463, 20);
            this.txtbuscod.TabIndex = 50;
            this.txtbuscod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbuscod_KeyUp);
            // 
            // txtbusnom
            // 
            this.txtbusnom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtbusnom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtbusnom.Location = new System.Drawing.Point(478, 279);
            this.txtbusnom.MaxLength = 50;
            this.txtbusnom.Name = "txtbusnom";
            this.txtbusnom.Size = new System.Drawing.Size(467, 20);
            this.txtbusnom.TabIndex = 49;
            this.txtbusnom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtbusnom_KeyUp);
            // 
            // dtgridcodigo
            // 
            this.dtgridcodigo.AllowUserToAddRows = false;
            this.dtgridcodigo.AllowUserToDeleteRows = false;
            this.dtgridcodigo.AllowUserToOrderColumns = true;
            this.dtgridcodigo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgridcodigo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridcodigo.Location = new System.Drawing.Point(9, 305);
            this.dtgridcodigo.Name = "dtgridcodigo";
            this.dtgridcodigo.ReadOnly = true;
            this.dtgridcodigo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgridcodigo.Size = new System.Drawing.Size(936, 279);
            this.dtgridcodigo.TabIndex = 1;
            this.dtgridcodigo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgridcodigo_CellClick);
            this.dtgridcodigo.SelectionChanged += new System.EventHandler(this.dtgridcodigo_SelectionChanged);
            // 
            // txtumedida
            // 
            this.txtumedida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtumedida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtumedida.Location = new System.Drawing.Point(88, 121);
            this.txtumedida.Name = "txtumedida";
            this.txtumedida.Size = new System.Drawing.Size(129, 20);
            this.txtumedida.TabIndex = 6;
            // 
            // txtprecio
            // 
            this.txtprecio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtprecio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtprecio.Location = new System.Drawing.Point(88, 177);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(129, 20);
            this.txtprecio.TabIndex = 8;
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            this.txtprecio.Validated += new System.EventHandler(this.txtprecio_Validated);
            // 
            // txtancho
            // 
            this.txtancho.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtancho.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtancho.Location = new System.Drawing.Point(517, 233);
            this.txtancho.Name = "txtancho";
            this.txtancho.Size = new System.Drawing.Size(129, 20);
            this.txtancho.TabIndex = 12;
            this.txtancho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtancho_KeyPress);
            this.txtancho.Validated += new System.EventHandler(this.txtancho_Validated);
            // 
            // txtalto
            // 
            this.txtalto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtalto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtalto.Location = new System.Drawing.Point(281, 233);
            this.txtalto.Name = "txtalto";
            this.txtalto.Size = new System.Drawing.Size(129, 20);
            this.txtalto.TabIndex = 11;
            this.txtalto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtalto_KeyPress);
            this.txtalto.Validated += new System.EventHandler(this.txtalto_Validated);
            // 
            // txtpeso
            // 
            this.txtpeso.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtpeso.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtpeso.Location = new System.Drawing.Point(88, 233);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(129, 20);
            this.txtpeso.TabIndex = 10;
            this.txtpeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpeso_KeyPress);
            this.txtpeso.Validated += new System.EventHandler(this.txtpeso_Validated);
            // 
            // txtstock
            // 
            this.txtstock.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtstock.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtstock.Location = new System.Drawing.Point(88, 205);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(129, 20);
            this.txtstock.TabIndex = 9;
            this.txtstock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtstock_KeyPress);
            // 
            // txtcodigoequiv
            // 
            this.txtcodigoequiv.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtcodigoequiv.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtcodigoequiv.Location = new System.Drawing.Point(170, 149);
            this.txtcodigoequiv.Name = "txtcodigoequiv";
            this.txtcodigoequiv.Size = new System.Drawing.Size(129, 20);
            this.txtcodigoequiv.TabIndex = 7;
            // 
            // lblancho
            // 
            this.lblancho.AutoSize = true;
            this.lblancho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblancho.Location = new System.Drawing.Point(450, 232);
            this.lblancho.Name = "lblancho";
            this.lblancho.Size = new System.Drawing.Size(60, 18);
            this.lblancho.TabIndex = 38;
            this.lblancho.Text = "Ancho:";
            // 
            // lblalto
            // 
            this.lblalto.AutoSize = true;
            this.lblalto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblalto.Location = new System.Drawing.Point(233, 232);
            this.lblalto.Name = "lblalto";
            this.lblalto.Size = new System.Drawing.Size(42, 18);
            this.lblalto.TabIndex = 37;
            this.lblalto.Text = "Alto:";
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpeso.Location = new System.Drawing.Point(6, 232);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(52, 18);
            this.lblpeso.TabIndex = 36;
            this.lblpeso.Text = "Peso:";
            // 
            // lblstock
            // 
            this.lblstock.AutoSize = true;
            this.lblstock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstock.Location = new System.Drawing.Point(6, 204);
            this.lblstock.Name = "lblstock";
            this.lblstock.Size = new System.Drawing.Size(57, 18);
            this.lblstock.TabIndex = 35;
            this.lblstock.Text = "Stock:";
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.Location = new System.Drawing.Point(6, 176);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(62, 18);
            this.lblprecio.TabIndex = 34;
            this.lblprecio.Text = "Precio:";
            // 
            // lblcodigoequiv
            // 
            this.lblcodigoequiv.AutoSize = true;
            this.lblcodigoequiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigoequiv.Location = new System.Drawing.Point(6, 148);
            this.lblcodigoequiv.Name = "lblcodigoequiv";
            this.lblcodigoequiv.Size = new System.Drawing.Size(158, 18);
            this.lblcodigoequiv.TabIndex = 33;
            this.lblcodigoequiv.Text = "Codigo Equivalente:";
            // 
            // lblmedida
            // 
            this.lblmedida.AutoSize = true;
            this.lblmedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmedida.Location = new System.Drawing.Point(6, 120);
            this.lblmedida.Name = "lblmedida";
            this.lblmedida.Size = new System.Drawing.Size(79, 18);
            this.lblmedida.TabIndex = 32;
            this.lblmedida.Text = "UMedida:";
            // 
            // lblsubrubro
            // 
            this.lblsubrubro.AutoSize = true;
            this.lblsubrubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubrubro.Location = new System.Drawing.Point(6, 92);
            this.lblsubrubro.Name = "lblsubrubro";
            this.lblsubrubro.Size = new System.Drawing.Size(82, 18);
            this.lblsubrubro.TabIndex = 31;
            this.lblsubrubro.Text = "Subrubro:";
            // 
            // lblrubro
            // 
            this.lblrubro.AutoSize = true;
            this.lblrubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrubro.Location = new System.Drawing.Point(6, 64);
            this.lblrubro.Name = "lblrubro";
            this.lblrubro.Size = new System.Drawing.Size(59, 18);
            this.lblrubro.TabIndex = 30;
            this.lblrubro.Text = "Rubro:";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(6, 36);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(73, 18);
            this.lblnombre.TabIndex = 29;
            this.lblnombre.Text = "Nombre:";
            // 
            // lblcodigo
            // 
            this.lblcodigo.AutoSize = true;
            this.lblcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcodigo.Location = new System.Drawing.Point(6, 8);
            this.lblcodigo.Name = "lblcodigo";
            this.lblcodigo.Size = new System.Drawing.Size(67, 18);
            this.lblcodigo.TabIndex = 28;
            this.lblcodigo.Text = "Codigo:";
            // 
            // txtnombrecod
            // 
            this.txtnombrecod.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtnombrecod.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtnombrecod.Location = new System.Drawing.Point(88, 32);
            this.txtnombrecod.MaxLength = 50;
            this.txtnombrecod.Name = "txtnombrecod";
            this.txtnombrecod.Size = new System.Drawing.Size(318, 20);
            this.txtnombrecod.TabIndex = 3;
            this.txtnombrecod.Leave += new System.EventHandler(this.txtnombrecod_Leave);
            // 
            // txtcodigo
            // 
            this.txtcodigo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtcodigo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtcodigo.Location = new System.Drawing.Point(88, 6);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(129, 20);
            this.txtcodigo.TabIndex = 2;
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            this.txtcodigo.Validated += new System.EventHandler(this.txtcodigo_Validated);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chkinhabilitar);
            this.tabPage2.Controls.Add(this.btnsyncp);
            this.tabPage2.Controls.Add(this.lblagrupacion);
            this.tabPage2.Controls.Add(this.txtlistart);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.Cbpvariable);
            this.tabPage2.Controls.Add(this.Cbpagrupado);
            this.tabPage2.Controls.Add(this.CBPulicar);
            this.tabPage2.Controls.Add(this.lbltags);
            this.tabPage2.Controls.Add(this.txttags);
            this.tabPage2.Controls.Add(this.lblRubrosEco);
            this.tabPage2.Controls.Add(this.chkrubros);
            this.tabPage2.Controls.Add(this.txtdetalles);
            this.tabPage2.Controls.Add(this.lbldetalle);
            this.tabPage2.Controls.Add(this.txtnombre);
            this.tabPage2.Controls.Add(this.txtarticulo);
            this.tabPage2.Controls.Add(this.lblarticulo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(951, 590);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Detalles Ecommerce";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chkinhabilitar
            // 
            this.chkinhabilitar.AutoSize = true;
            this.chkinhabilitar.Location = new System.Drawing.Point(472, 59);
            this.chkinhabilitar.Name = "chkinhabilitar";
            this.chkinhabilitar.Size = new System.Drawing.Size(116, 17);
            this.chkinhabilitar.TabIndex = 14;
            this.chkinhabilitar.Text = "Inhabilitar producto";
            this.chkinhabilitar.UseVisualStyleBackColor = true;
            // 
            // btnsyncp
            // 
            this.btnsyncp.BackColor = System.Drawing.Color.LightBlue;
            this.btnsyncp.Location = new System.Drawing.Point(336, 53);
            this.btnsyncp.Name = "btnsyncp";
            this.btnsyncp.Size = new System.Drawing.Size(130, 26);
            this.btnsyncp.TabIndex = 13;
            this.btnsyncp.Text = "S&yncronizar producto";
            this.btnsyncp.UseVisualStyleBackColor = true;
            this.btnsyncp.Click += new System.EventHandler(this.btnsyncp_Click);
            // 
            // lblagrupacion
            // 
            this.lblagrupacion.AutoSize = true;
            this.lblagrupacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblagrupacion.Location = new System.Drawing.Point(227, 303);
            this.lblagrupacion.Name = "lblagrupacion";
            this.lblagrupacion.Size = new System.Drawing.Size(196, 18);
            this.lblagrupacion.TabIndex = 42;
            this.lblagrupacion.Text = "Agrupacion de productos";
            // 
            // txtlistart
            // 
            this.txtlistart.Location = new System.Drawing.Point(230, 333);
            this.txtlistart.Name = "txtlistart";
            this.txtlistart.Size = new System.Drawing.Size(236, 20);
            this.txtlistart.TabIndex = 20;
            this.txtlistart.TextChanged += new System.EventHandler(this.txtlistart_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(472, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 24);
            this.button2.TabIndex = 23;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 24);
            this.button1.TabIndex = 22;
            this.button1.Text = ">";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(506, 331);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(235, 172);
            this.listBox2.Sorted = true;
            this.listBox2.TabIndex = 24;
            this.listBox2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseDoubleClick);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(230, 355);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(236, 148);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 21;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // Cbpvariable
            // 
            this.Cbpvariable.AutoSize = true;
            this.Cbpvariable.Location = new System.Drawing.Point(725, 59);
            this.Cbpvariable.Name = "Cbpvariable";
            this.Cbpvariable.Size = new System.Drawing.Size(109, 17);
            this.Cbpvariable.TabIndex = 16;
            this.Cbpvariable.Text = "Producto variable";
            this.Cbpvariable.UseVisualStyleBackColor = true;
            // 
            // Cbpagrupado
            // 
            this.Cbpagrupado.AutoSize = true;
            this.Cbpagrupado.Location = new System.Drawing.Point(603, 59);
            this.Cbpagrupado.Name = "Cbpagrupado";
            this.Cbpagrupado.Size = new System.Drawing.Size(117, 17);
            this.Cbpagrupado.TabIndex = 15;
            this.Cbpagrupado.Text = "Producto agrupado";
            this.Cbpagrupado.UseVisualStyleBackColor = true;
            // 
            // CBPulicar
            // 
            this.CBPulicar.AutoSize = true;
            this.CBPulicar.Location = new System.Drawing.Point(840, 59);
            this.CBPulicar.Name = "CBPulicar";
            this.CBPulicar.Size = new System.Drawing.Size(87, 17);
            this.CBPulicar.TabIndex = 17;
            this.CBPulicar.Text = "Publicar web";
            this.CBPulicar.UseVisualStyleBackColor = true;
            // 
            // lbltags
            // 
            this.lbltags.AutoSize = true;
            this.lbltags.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltags.Location = new System.Drawing.Point(754, 303);
            this.lbltags.Name = "lbltags";
            this.lbltags.Size = new System.Drawing.Size(45, 18);
            this.lbltags.TabIndex = 33;
            this.lbltags.Text = "Tags";
            // 
            // txttags
            // 
            this.txttags.Location = new System.Drawing.Point(757, 331);
            this.txttags.Multiline = true;
            this.txttags.Name = "txttags";
            this.txttags.Size = new System.Drawing.Size(170, 111);
            this.txttags.TabIndex = 25;
            // 
            // lblRubrosEco
            // 
            this.lblRubrosEco.AutoSize = true;
            this.lblRubrosEco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRubrosEco.Location = new System.Drawing.Point(24, 303);
            this.lblRubrosEco.Name = "lblRubrosEco";
            this.lblRubrosEco.Size = new System.Drawing.Size(182, 18);
            this.lblRubrosEco.TabIndex = 32;
            this.lblRubrosEco.Text = "Rubros de Ecommerce";
            // 
            // chkrubros
            // 
            this.chkrubros.FormattingEnabled = true;
            this.chkrubros.Location = new System.Drawing.Point(27, 333);
            this.chkrubros.Name = "chkrubros";
            this.chkrubros.Size = new System.Drawing.Size(197, 169);
            this.chkrubros.TabIndex = 19;
            // 
            // txtdetalles
            // 
            this.txtdetalles.Location = new System.Drawing.Point(27, 91);
            this.txtdetalles.MaxLength = 4000;
            this.txtdetalles.Multiline = true;
            this.txtdetalles.Name = "txtdetalles";
            this.txtdetalles.Size = new System.Drawing.Size(900, 199);
            this.txtdetalles.TabIndex = 18;
            // 
            // lbldetalle
            // 
            this.lbldetalle.AutoSize = true;
            this.lbldetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldetalle.Location = new System.Drawing.Point(24, 59);
            this.lbldetalle.Name = "lbldetalle";
            this.lbldetalle.Size = new System.Drawing.Size(60, 18);
            this.lbldetalle.TabIndex = 27;
            this.lbldetalle.Text = "Detalle";
            // 
            // txtnombre
            // 
            this.txtnombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtnombre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtnombre.Location = new System.Drawing.Point(230, 7);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(318, 20);
            this.txtnombre.TabIndex = 25;
            this.txtnombre.Leave += new System.EventHandler(this.txtnombre_Leave);
            // 
            // txtarticulo
            // 
            this.txtarticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtarticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtarticulo.Location = new System.Drawing.Point(95, 7);
            this.txtarticulo.Name = "txtarticulo";
            this.txtarticulo.Size = new System.Drawing.Size(129, 20);
            this.txtarticulo.TabIndex = 24;
            this.txtarticulo.TextChanged += new System.EventHandler(this.txtarticulo_TextChanged_1);
            this.txtarticulo.Leave += new System.EventHandler(this.txtarticulo_Leave);
            // 
            // lblarticulo
            // 
            this.lblarticulo.AutoSize = true;
            this.lblarticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblarticulo.Location = new System.Drawing.Point(24, 7);
            this.lblarticulo.Name = "lblarticulo";
            this.lblarticulo.Size = new System.Drawing.Size(65, 18);
            this.lblarticulo.TabIndex = 23;
            this.lblarticulo.Text = "Articulo";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.LightBlue;
            this.btnlimpiar.Location = new System.Drawing.Point(596, 635);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(87, 32);
            this.btnlimpiar.TabIndex = 17;
            this.btnlimpiar.Text = "&Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.LightBlue;
            this.btnbuscar.Location = new System.Drawing.Point(411, 635);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(86, 32);
            this.btnbuscar.TabIndex = 15;
            this.btnbuscar.Text = "&Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.LightBlue;
            this.btnmodificar.Location = new System.Drawing.Point(318, 635);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(87, 32);
            this.btnmodificar.TabIndex = 14;
            this.btnmodificar.Text = "&Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackColor = System.Drawing.Color.LightBlue;
            this.btnnuevo.Location = new System.Drawing.Point(225, 635);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(87, 32);
            this.btnnuevo.TabIndex = 13;
            this.btnnuevo.Text = "&Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 679);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btngrabar);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.btnlimpiar);
            this.KeyPreview = true;
            this.Name = "Productos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.label.ResumeLayout(false);
            this.label.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridcodigo)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btngrabar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage label;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnsyncp;
        private System.Windows.Forms.Label lblagrupacion;
        private System.Windows.Forms.TextBox txtlistart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox Cbpvariable;
        private System.Windows.Forms.CheckBox Cbpagrupado;
        private System.Windows.Forms.CheckBox CBPulicar;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Label lbltags;
        private System.Windows.Forms.TextBox txttags;
        private System.Windows.Forms.Label lblRubrosEco;
        private System.Windows.Forms.CheckedListBox chkrubros;
        private System.Windows.Forms.TextBox txtdetalles;
        private System.Windows.Forms.Label lbldetalle;
        public System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Button btnbuscar;
        public System.Windows.Forms.TextBox txtarticulo;
        private System.Windows.Forms.Label lblarticulo;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblcodigo;
        public System.Windows.Forms.TextBox txtnombrecod;
        public System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label lblsubrubro;
        private System.Windows.Forms.Label lblrubro;
        public System.Windows.Forms.TextBox txtumedida;
        public System.Windows.Forms.TextBox txtprecio;
        public System.Windows.Forms.TextBox txtancho;
        public System.Windows.Forms.TextBox txtalto;
        public System.Windows.Forms.TextBox txtpeso;
        public System.Windows.Forms.TextBox txtstock;
        public System.Windows.Forms.TextBox txtcodigoequiv;
        private System.Windows.Forms.Label lblancho;
        private System.Windows.Forms.Label lblalto;
        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.Label lblstock;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.Label lblcodigoequiv;
        private System.Windows.Forms.Label lblmedida;
        public System.Windows.Forms.TextBox txtbuscod;
        public System.Windows.Forms.TextBox txtbusnom;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.CheckBox chkinhabilitar;
        public System.Windows.Forms.ComboBox cmbsubrubro;
        public System.Windows.Forms.ComboBox cmbrubro;
        public System.Windows.Forms.DataGridView dtgridcodigo;
    }
}

