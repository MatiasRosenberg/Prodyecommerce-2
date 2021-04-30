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
            }
        }
    }
}
