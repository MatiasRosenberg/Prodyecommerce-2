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
    public partial class Subrubros : Form
    {
        public Subrubros()
        {
            InitializeComponent();
        }

        Funciones F = new Funciones();
        SqlCommand cmd = new SqlCommand();
        SqlConnection cnn = BaseDatos.DbConnection.getDBConnection();

        private bool btnnuevoFuePresionado = false;
        private bool btnmodificarfuepresionado = false;

        private void Subrubros_Load(object sender, EventArgs e)
        {
            F.Llenarsubrubros(dgvsubrubros);
            txtidsubrubro.Enabled = false;
            txtnombre.Enabled = false;
            cbpublicar.Enabled = false;
            txtidsubrubrobus.Enabled = true;
            txtnombrebus.Enabled = true;
            btnnuevo.Enabled = true;
            btnmodificar.Enabled = true;
            btngrabar.Enabled = false;
            btnlimpiar.Enabled = false;
            btnsalir.Enabled = true;
            dgvsubrubros.Enabled = true;
            dgvsubrubros.Focus();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvsubrubros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            else
            {
                txtidsubrubro.Text = dgvsubrubros.Rows[e.RowIndex].Cells["codigo"].Value.ToString();
                txtnombre.Text = dgvsubrubros.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            }
        }

        private void dgvsubrubros_SelectionChanged(object sender, EventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;
            if (row != null)
            {
                txtidsubrubro.Text = row.Cells[0].Value.ToString();
                txtnombre.Text = row.Cells[1].Value.ToString();

                F.publicarwebsr(txtidsubrubro, cbpublicar);
            }
        }

        private void txtidsubrubrobus_KeyUp(object sender, KeyEventArgs e)
        {
            cmd = new SqlCommand("Select idsubrubro as Codigo, Nombre from subrubros where idsubrubro like('" + txtidsubrubrobus.Text + "%')", cnn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvsubrubros.DataSource = dt;
        }

        private void txtnombrebus_KeyUp(object sender, KeyEventArgs e)
        {
            cmd = new SqlCommand("Select idsubrubro as Codigo, Nombre from subrubros where nombre like('" + txtnombrebus.Text + "%')", cnn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvsubrubros.DataSource = dt;
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtidsubrubro.Text = "";
            txtnombre.Text = "";
            txtidsubrubrobus.Text = "";
            txtnombrebus.Text = "";
            cbpublicar.Checked = false;
            txtidsubrubro.Focus();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            btnlimpiar_Click(null, null);
            btnnuevoFuePresionado = true;
            btnmodificarfuepresionado = false;
            txtidsubrubro.Enabled = true;
            txtnombre.Enabled = true;
            txtidsubrubrobus.Enabled = false;
            txtnombrebus.Enabled = false;
            btnmodificar.Enabled = false;
            btngrabar.Enabled = true;
            btnnuevo.Enabled = false;
            btnlimpiar.Enabled = true;
            btnsalir.Enabled = false;
            cbpublicar.Enabled = true;
            dgvsubrubros.Enabled = false;
            txtidsubrubro.Focus();
        }

        private void btngrabar_Click(object sender, EventArgs e)
        {
            if (btnnuevoFuePresionado == true)
            {
                F.grabarsubrubros(txtidsubrubro, txtnombre, cbpublicar);
            }
            else if (btnmodificarfuepresionado == true)
            {
                F.modificarsubrubros(txtidsubrubro, txtnombre, cbpublicar);
            }
            Subrubros_Load(sender, e);
            dgvsubrubros.Focus();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            btnmodificarfuepresionado = true;
            btnnuevoFuePresionado = false;
            txtnombre.Enabled = true;
            cbpublicar.Enabled = true;
            dgvsubrubros.Enabled = false;
            btnnuevo.Enabled = false;
            btnmodificar.Enabled = false;
            btngrabar.Enabled = true;
            btnlimpiar.Enabled = false;
            btnsalir.Enabled = false;
            txtidsubrubrobus.Enabled = false;
            txtnombrebus.Enabled = false;
            txtnombre.Focus();
        }

        private void txtidsubrubro_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtidsubrubro.Text))
            {
                MessageBox.Show("Completar codigo de articulo");
                txtidsubrubro.Focus();
                return;
            }
            else
            {
                F.Subrubroregistrado(txtidsubrubro);
            }
        }
    }
}
