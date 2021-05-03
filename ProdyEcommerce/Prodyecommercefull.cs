using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProdyEcommerce
{
    public partial class Prodyecommercefull : Form
    {
        Funciones F = new Funciones();
        public Prodyecommercefull()
        {
            InitializeComponent();
        }

        private void Btnproductos_Click(object sender, EventArgs e)
        {
            Productos p = new Productos();

            p.ShowDialog();
            F.sync(lblsync0, lblsync1);
        }

        private void Btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnconfiguracion_Click(object sender, EventArgs e)
        {
            Configuracion C = new Configuracion();

            C.ShowDialog();
            F.sync(lblsync0, lblsync1);
        }

        private void btnjerarquia_Click(object sender, EventArgs e)
        {
            Jerarquia_de_rubros J = new Jerarquia_de_rubros();

            J.ShowDialog();
        }

        private void Prodyecommerce_Load(object sender, EventArgs e)
        {
            F.sync(lblsync0, lblsync1);

            this.Text = "Prodyecommerce Version:" + Application.ProductVersion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F.sync(lblsync0, lblsync1);
        }

        private void Btnrubrosysubrubros_Click(object sender, EventArgs e)
        {
            ProdyEcommercefull.Rurbos R = new ProdyEcommercefull.Rurbos();

            R.ShowDialog();
        }

        private void Btnsubrubros_Click(object sender, EventArgs e)
        {
            ProdyEcommercefull.Subrubros S = new ProdyEcommercefull.Subrubros();

            S.ShowDialog();
        }
    }
}
