﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdyEcommerce
{
    public partial class Productos : Form
    {

        Funciones F = new Funciones();
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnn = BaseDatos.DbConnection.getDBConnection();

        public Productos()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Funciones F = new Funciones();
            txtarticulo.AutoCompleteCustomSource = Funciones.AutoCompleClass.Autocomplete();
            txtarticulo.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtarticulo.AutoCompleteSource = AutoCompleteSource.CustomSource;
            F.Llenardatagrid(dtgridcodigo);

            txtcodigo.Enabled = false;
            txtnombrecod.Enabled = false;
            cmbrubro.Enabled = false;
            cmbsubrubro.Enabled = false;
            txtumedida.Enabled = false;
            txtcodigoequiv.Enabled = false;
            txtprecio.Enabled = false;
            txtstock.Enabled = false;
            txtpeso.Enabled = false;
            txtalto.Enabled = false;
            txtancho.Enabled = false;
            txtarticulo.Enabled = false;
            txtnombre.Enabled = false;
            txtdetalles.Enabled = false;
            txtdetalles.Enabled = false;
            chkrubros.Enabled = false;
            listBox1.Enabled = false;
            listBox2.Enabled = false;
            txttags.Enabled = false;
            btngrabar.Enabled = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
        Busqueda_avanzada busqueda = new Busqueda_avanzada();
        
        private void btngrabar_Click(object sender, EventArgs e)
        {
            if(txtarticulo.Text == "" && txtnombre.Text == "")
            {
                MessageBox.Show("El articulo o nombre estan vacios");
            }
            else
            {
                F.Grabararticulos(txtarticulo, txttags, txtdetalles, CBPulicar, Cbpagrupado, Cbpvariable, chkrubros, listBox2, listBox1);
                btnlimpiar_Click(null, null);
            }
        }

        private void txtarticulo_TextChanged_1(object sender, EventArgs e)
        {
            if (txtarticulo.Text == "")
            {
                F.Llenarproductos(txtnombre, txtdetalles, txttags, chkrubros, txtarticulo, CBPulicar, Cbpvariable, Cbpagrupado, listBox1, listBox2);
                txtarticulo.Enabled = false;
                txtnombre.Enabled = false;
            }
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            F.Llenarproductos(txtnombre, txtdetalles, txttags, chkrubros, txtarticulo, CBPulicar, Cbpvariable, Cbpagrupado, listBox1, listBox2);
            txtarticulo.Enabled = false;
            txtnombre.Enabled = false;
        }

        private void txtarticulo_Leave(object sender, EventArgs e)
        {
            if (txtnombre.Text == "")
            {
                F.Llenarproductos(txtnombre, txtdetalles, txttags, chkrubros, txtarticulo, CBPulicar, Cbpvariable, Cbpagrupado, listBox1, listBox2);
                txtarticulo.Enabled = false;
                txtnombre.Enabled = false;
            }
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtarticulo.Text = "";
            txtdetalles.Text = "";
            txtnombre.Text = "";
            txttags.Text = "";
            Cbpagrupado.Checked = false;
            CBPulicar.Checked = false;
            txtarticulo.Enabled = true;
            txtnombre.Enabled = true;
            btnbuscar.Enabled = true;
            chkrubros.DataSource = null;
            chkrubros.Items.Clear();
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            listBox2.DataSource = null;
            listBox2.Items.Clear();
            txtarticulo.Focus();
        }

        private void btnsyncp_Click(object sender, EventArgs e)
        {
            string Csqlsync = "update articulos set sync=0 from articulos a left join rubros r on r.idrubro = a.idrubro left join subrubros s on s.IdSubRubro = a.IdSubRubro where  r.publicarweb = 1 and a.inhabilitado = 0 and s.PUBLICARWEB = 1 and a.PUBLICARWEB = 1 and idarticulo ='" + txtarticulo.Text + "'";

            try
            {
                SqlCommand cmd = new SqlCommand(Csqlsync, cnn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Articulo sincronizado");
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede sincronizar este articulo");
            }
        }

        List<string> listcollection = new List<string>();
        private void txtlistart_TextChanged(object sender, EventArgs e)
        {
            int index = listBox1.FindString(this.txtlistart.Text);
            if (0 <= index)
            {
                listBox1.SelectedIndex = index;
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            F.Cambiolista(listBox1, listBox2);
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F.Cambiolista(listBox1, listBox2);
        }

        private void txtnombre_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtarticulo.Text) == true)
            {
                F.Llenarproductos(txtnombre, txtdetalles, txttags, chkrubros, txtarticulo, CBPulicar, Cbpvariable, Cbpagrupado, listBox1, listBox2);
                txtarticulo.Enabled = false;
                txtnombre.Enabled = false;
            }
        }

        private void txtarticulo_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtarticulo.Text) == true || string.IsNullOrEmpty(txtnombre.Text) == true)
            {
                txtarticulo.Enabled = false;
            }
            else
            {
                txtarticulo.Enabled = true;
            }
        }

        private void txtnombre_Validated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtarticulo.Text) == true || string.IsNullOrEmpty(txtnombre.Text) == true)
            {
                txtnombre.Enabled = false;
            }
            else
            {
                txtnombre.Enabled = true;
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtarticulo.Text) == true || string.IsNullOrEmpty(txtnombre.Text) == true || string.IsNullOrEmpty(txtcodigo.Text) == true || string.IsNullOrEmpty(txtnombrecod.Text) == true)
            {
                busqueda.ShowDialog();
                txtarticulo.Enabled = true;
                txtnombre.Enabled = true;
            }
        }

        private void txtbusnom_KeyUp(object sender, KeyEventArgs e)
        {
            cmd = new SqlCommand("Select idarticulo as Codigo, Nombre from articulos where Nombre like('" + txtbusnom.Text + "%')", cnn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dtgridcodigo.DataSource = dt;
        }

        private void txtbuscod_KeyUp(object sender, KeyEventArgs e)
        {
            cmd = new SqlCommand("Select idarticulo as Codigo, Nombre from articulos where idarticulo like('" + txtbuscod.Text + "%')", cnn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dtgridcodigo.DataSource = dt;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {

            txtcodigo.Enabled = true;
            txtnombrecod.Enabled = true;
            cmbrubro.Enabled = true;
            cmbsubrubro.Enabled = true;
            txtumedida.Enabled = true;
            txtcodigoequiv.Enabled = true;
            txtprecio.Enabled = true;
            txtstock.Enabled = true;
            txtpeso.Enabled = true;
            txtalto.Enabled = true;
            txtancho.Enabled = true;
            txtarticulo.Enabled = true;
            txtnombre.Enabled = true;
            txtdetalles.Enabled = true;
            txtdetalles.Enabled = true;
            chkrubros.Enabled = true;
            listBox1.Enabled = true;
            listBox2.Enabled = true;
            txttags.Enabled = true;
            btngrabar.Enabled = true;
        }
    }
}