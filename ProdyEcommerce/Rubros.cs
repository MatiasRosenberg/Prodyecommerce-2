using ProdyEcommerce;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdyEcommercefull
{
    public partial class Rurbos : Form
    {
        public Rurbos()
        {
            InitializeComponent();
        }

        Funciones F = new Funciones();
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnn = BaseDatos.DbConnection.getDBConnection();

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Rurbos_Load(object sender, EventArgs e)
        {
            F.Llenarrubros(dgvrubros);
            txtidrubro.Enabled = false;
            txtnombre.Enabled = false;
            cbpublicar.Enabled = false;
            txtidrubrobus.Enabled = true;
            txtnombrebus.Enabled = true;
            btnnuevo.Enabled = true;
            btnmodificar.Enabled = true;
            btngrabar.Enabled = false;
            btnlimpiar.Enabled = false;
            btnsalir.Enabled = true;
            dgvrubros.Focus();
        }

        private void txtidrubrobus_KeyUp(object sender, KeyEventArgs e)
        {
            cmd = new SqlCommand("Select idrubro as Codigo, Nombre from rubros where idrubro like('" + txtidrubrobus.Text + "%')", cnn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvrubros.DataSource = dt;
        }

        private void txtnombrebus_KeyUp(object sender, KeyEventArgs e)
        {
            cmd = new SqlCommand("Select idrubro as Codigo, Nombre from rubros where nombre like('" + txtnombrebus.Text + "%')", cnn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvrubros.DataSource = dt;
        }

        private void dgvrubros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                txtidrubro.Text = dgvrubros.Rows[e.RowIndex].Cells["idrubro"].Value.ToString();
                txtnombre.Text = dgvrubros.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            }
        }

        private void dgvrubros_SelectionChanged(object sender, EventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;
            if (row != null)
            {
                txtidrubro.Text = row.Cells[0].Value.ToString();
                txtnombre.Text = row.Cells[1].Value.ToString();

                F.publicarwebr(txtidrubro, cbpublicar);
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            btnlimpiar_Click(null, null);
            btnnuevoFuePresionado = true;
            btnmodificarfuepresionado = false;
            txtidrubro.Enabled = true;
            txtnombre.Enabled = true;
            txtidrubrobus.Enabled = false;
            txtnombrebus.Enabled = false;
            btnmodificar.Enabled = false;
            btngrabar.Enabled = true;
            btnnuevo.Enabled = false;
            btnlimpiar.Enabled = true;
            btnsalir.Enabled = false;
            cbpublicar.Enabled = true;
            txtidrubro.Focus();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtidrubro.Text = "";
            txtnombre.Text = "";
            txtidrubrobus.Text = "";
            txtnombrebus.Text = "";
            cbpublicar.Checked = false;
            txtidrubro.Focus();
        }

        private bool btnnuevoFuePresionado = false;
        private bool btnmodificarfuepresionado = false;
        private void btngrabar_Click(object sender, EventArgs e)
        {
            if (btnnuevoFuePresionado == true)
            {
                F.grabarrubros(txtidrubro, txtnombre, cbpublicar);
            }
            else if (btnmodificarfuepresionado == true)
            {
                F.modificarrubros(txtidrubro, txtnombre, cbpublicar);
            }
            btnlimpiar_Click(null, null);
            Rurbos_Load(sender, e);
            dgvrubros.Focus();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            btnmodificarfuepresionado = true;
            btnnuevoFuePresionado = false;
            txtnombre.Enabled = true;
            cbpublicar.Enabled = true;
            dgvrubros.Enabled = false;
            btnnuevo.Enabled = false;
            btnmodificar.Enabled = false;
            btngrabar.Enabled = true;
            btnlimpiar.Enabled = false;
            btnsalir.Enabled = false;
            txtidrubrobus.Enabled = false;
            txtnombrebus.Enabled = false;
            txtnombre.Focus();
        }

        private void txtidrubro_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtidrubro.Text))
            {
                MessageBox.Show("Completar codigo de articulo");
                txtidrubro.Focus();
                return;
            }
            else
            {
                F.Rubroregistrado(txtidrubro);
            }
        }
    }
}
