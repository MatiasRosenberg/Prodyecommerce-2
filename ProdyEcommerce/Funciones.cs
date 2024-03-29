﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
using System.Data.OleDb;

namespace ProdyEcommerce
{
    class Funciones
    {
        SqlConnection cnn = BaseDatos.DbConnection.getDBConnection();
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter da;

        public static class AutoCompleClass
        {
            public static DataTable Datos()
            {
                DataTable dt = new DataTable();

                SqlConnection cnn = BaseDatos.DbConnection.getDBConnection();
                string sql = "select idarticulo, nombre from articulos";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                return dt;

            }

            public static AutoCompleteStringCollection Autocomplete()
            {
                DataTable dt = Datos();

                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
                foreach (DataRow row in dt.Rows)
                {
                    coleccion.Add(Convert.ToString(row["idarticulo"]));
                    coleccion.Add(Convert.ToString(row["nombre"]));
                }

                return coleccion;

            }

            public static AutoCompleteStringCollection Autocompleteidarticulo()
            {
                DataTable dt = Datos();

                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
                foreach (DataRow row in dt.Rows)
                {
                    coleccion.Add(Convert.ToString(row["idarticulo"]));
                }

                return coleccion;

            }

            public static AutoCompleteStringCollection Autocompletenombre()
            {
                DataTable dt = Datos();

                AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
                foreach (DataRow row in dt.Rows)
                {
                    coleccion.Add(Convert.ToString(row["nombre"]));
                }

                return coleccion;

            }

        }

        public void Llenarproductos(TextBox cajanombre, TextBox cajadetalle, TextBox cajatags, CheckedListBox listarubros, TextBox cajaidarticulo, TextBox cajaumedida, TextBox codequiv, TextBox cajapeso, TextBox cajaalto, TextBox cajaancho, CheckBox checkweb, CheckBox Checkvariable, CheckBox agrupar, ListBox lista1, ListBox lista2, TextBox Precios, ComboBox cbrubros, ComboBox cbsubrubros, TextBox cajastock, CheckBox InHabilitado)
        {
            DataTable ConfigData = new DataTable();
            string sql = "Select * From Configuracion";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ConfigData);

            cmd = new SqlCommand("Select nombre, idarticulo, UniMedi, isnull(WOO_DETALLE, '') WOO_DETALLE, CodEquiv, Peso, isnull(Alto, 0) Alto, isnull(Ancho, 0) Ancho  from articulos where idarticulo='" + cajaidarticulo.Text + "'", cnn);
            SqlDataReader read = cmd.ExecuteReader();
            cmd = new SqlCommand("Select TAGS from ecomm_tags where idarticulo='" + cajaidarticulo.Text + "'", cnn);
            SqlDataReader read1 = cmd.ExecuteReader();

            //dtrubros
            DataTable dt = new DataTable();

            string consultarubros = "select idRubro, Nombre from rubros order by nombre asc";
            cmd = new SqlCommand(consultarubros, cnn);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            listarubros.DataSource = dt;
            listarubros.DisplayMember = "Nombre";
            listarubros.ValueMember = "idRubro";

            string Csqlrubros = "select articulos.IdArticulo as idarticulo ,rubros.idrubro as rubro, rubros.Nombre as nombre from rubros left join Articulos on rubros.idrubro = articulos.idrubro where idarticulo = '" + cajaidarticulo.Text + "'" + " order by nombre asc";
            da = new SqlDataAdapter(Csqlrubros, cnn);
            DataTable rubro = new DataTable();
            da.Fill(rubro);

            string Csqlsubrubros = "select articulos.IdArticulo as idarticulo , subrubros.IdSubRubro as subrubro, subrubros.Nombre as nombre from Subrubros left join Articulos on  subrubros.IdSubRubro = articulos.idsubrubro where idarticulo = '" + cajaidarticulo.Text + "'" + " order by nombre asc";
            da = new SqlDataAdapter(Csqlsubrubros, cnn);
            DataTable subrubro = new DataTable();
            da.Fill(subrubro);

            //comborubros
            cbrubros.DisplayMember = "Nombre";
            cbrubros.ValueMember = "idrubro";
            cbrubros.DataSource = rubro;

            cbsubrubros.DisplayMember = "Nombre";
            cbsubrubros.ValueMember = "idsubrubro";
            cbsubrubros.DataSource = subrubro;

            string Csql = "select idarticulo, idrubro from rubrosarticulos where idarticulo ='" + cajaidarticulo.Text + "'";
            cmd = new SqlCommand(Csql, cnn);
            SqlDataReader read2 = cmd.ExecuteReader();

            string CsqlCheck = "select isnull(woo_agrupado, 0) agrupado , isnull(InHabilitado, 0) InHabilitado, isnull(publicarweb, 0) as publicarweb, isnull(woo_variable, 0) as woo_variable from articulos where idarticulo ='" + cajaidarticulo.Text + "'";
            cmd = new SqlCommand(CsqlCheck, cnn);
            SqlDataReader read3 = cmd.ExecuteReader();


            string Csqllista = "select ARTICULOSJERARQUIAS.IDARTICULO as idarticulo, Articulos.Nombre as nombre from ARTICULOSJERARQUIAS left join articulos on ARTICULOSJERARQUIAS.IDARTICULO = Articulos.IdArticulo where ARTICULOSJERARQUIAS.IDARTICULOFATHER ='" + cajaidarticulo.Text + "'";
            cmd = new SqlCommand(Csqllista, cnn);
            SqlDataReader read4 = cmd.ExecuteReader();

            string Csqlprecioecomm = "select precio from precios where idarticulo  ='" + cajaidarticulo.Text + "'" + "and idlista='" + ConfigData.Rows[0]["SHOPPRICELIST"].ToString() + "'";
            cmd = new SqlCommand(Csqlprecioecomm, cnn);
            SqlDataReader read5 = cmd.ExecuteReader();

            string Csqlstock = "select Cantidad from stock where idarticulo ='" + cajaidarticulo.Text + "'" + "and iddeposito='" + ConfigData.Rows[0]["SHOPSTOCKID"].ToString() + "'";
            cmd = new SqlCommand(Csqlstock, cnn);
            SqlDataReader read6 = cmd.ExecuteReader();

            DataTable dtlista1 = new DataTable();
            string Csqllist = "select idarticulo, Nombre from articulos order by Nombre asc";
            cmd = new SqlCommand(Csqllist, cnn);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            da1.Fill(dtlista1);

            //Llenar listbox1 y listbox2
            lista1.DataSource = dtlista1;
            lista1.DisplayMember = "Nombre";
            lista1.ValueMember = "idarticulo";

            if(read4.HasRows)
            {
                while(read4.Read())
                {
                    lista2.Items.Add(read4.GetString(1)+ "?" + read4.GetString(0));
                    var _items = lista2.Items.Cast<string>().Distinct().ToArray();
                    lista2.Items.Clear();
                    foreach (var item in _items)
                    {
                        lista2.Items.Add(item);
                    }   
                }
            }

            //recorrer checklistbox
            if (read2.HasRows)
            {
                while (read2.Read())
                {
                    /* Con esta logica, se obtiene el valor y el nombre de cada elemento del checklistbox */
                    for (int i = 0; i < listarubros.Items.Count; i++)
                    {
                        DataRowView r = (DataRowView)listarubros.Items[i];
                        string val = (r[listarubros.ValueMember]).ToString();
                        string dis = (r[listarubros.DisplayMember]).ToString();
                        r = null;
                        if (read2["Idrubro"].ToString() == val)
                        {
                            listarubros.SetItemChecked(i, true);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            read2.Close();



            //Nombre, woo_detalle
            if (read.Read() == true)
            {
                cajanombre.Text = read["nombre"].ToString();
                cajadetalle.Text = read["WOO_DETALLE"].ToString();
                cajaumedida.Text = read["UniMedi"].ToString();
                codequiv.Text = read["CodEquiv"].ToString();
                cajapeso.Text = read["Peso"].ToString();
                cajaalto.Text = read["Alto"].ToString();
                cajaancho.Text = read["Ancho"].ToString();
            }
            else
            {
                cajanombre.Text = "";
                cajadetalle.Text = "";
                cajaumedida.Text = "";
                codequiv.Text = "";
                cajapeso.Text = "";
                cajaalto.Text = "";
                cajaancho.Text = "";
            }

            //tags
            if (read1.Read() == true)
            {
                cajatags.Text = read1["TAGS"].ToString();
            }
            else
            {
                cajatags.Text = "";
            }

            //checkboxs
            if (read3.Read() == true)
            {
                checkweb.Checked = Convert.ToBoolean(read3["publicarweb"]);
                Checkvariable.Checked = Convert.ToBoolean(read3["woo_Variable"]);
                agrupar.Checked = Convert.ToBoolean(read3["agrupado"]);
                InHabilitado.Checked = Convert.ToBoolean(read3["InHabilitado"]);
            }
            else
            {
                checkweb.Checked = false;
                Checkvariable.Checked = false;
                agrupar.Checked = false;
                InHabilitado.Checked = false;
            }

            if(read5.Read() == true)
            {
                Precios.Text = read5["Precio"].ToString();
            }
            else
            {
                Precios.Text = "";
            }

            if (read6.Read() == true)
            {
                cajastock.Text = read6["Cantidad"].ToString();
            }
            else
            {
                cajastock.Text = "";
            }
        }

        public void Llenardatagrid(DataGridView dgv)
        {
            try
            {
                string datagrida = "select idarticulo as Codigo, Nombre from articulos";

                da = new SqlDataAdapter(datagrida, cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
        }

        public void Llenarrubros(DataGridView dgv)
        {
            try
            {
                string rubros = "select idrubro as Idrubro, nombre from rubros";

                da = new SqlDataAdapter(rubros, cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
        }

        public void Llenarsubrubros(DataGridView dgv)
        {
            try
            {
                string subrubros = "select idSubRubro as Idsubrubro, nombre from subrubros";

                da = new SqlDataAdapter(subrubros, cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar la tabla" + ex.ToString());
            }
        }

        public void Grabararticulos(TextBox idarticulo, TextBox txttags, TextBox txtdetalle, CheckBox CBweb, CheckBox CBgroup, CheckBox CBvariable, CheckedListBox listarubros, ListBox lista2, ListBox lista1, TextBox nombre, ComboBox rubro, ComboBox subrubro, TextBox umedida, TextBox codeqvuiv, TextBox alto, TextBox ancho, TextBox peso, TextBox precio, TextBox cantidad, CheckBox InHabilitado)
        {

            DataTable ConfigData = new DataTable();
            string sql = "Select * From Configuracion";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ConfigData);


            string cSqldelete = "delete from ecomm_tags  where idarticulo ='" + idarticulo.Text + "'";
            string cSqlinserttags = "insert into ecomm_tags (idarticulo, tags) values(" + "'" + idarticulo.Text + "'" + "," + "'" + txttags.Text + "'" + ")";
            string Csqlrubros = "select idarticulo, idrubro from rubrosarticulos where idarticulo ='" + idarticulo.Text + "'";
            string Csqllistaartd = "delete from ARTICULOSJERARQUIAS where IDARTICULOFATHER='" + idarticulo.Text + "'";
            string Csqlipbasico = "insert into articulos (idarticulo, idarticulobarra , nombre, idrubro, idsubrubro, UniMedi, codequiv, alto, ancho, peso, idclase, WOO_DETALLE, publicarweb, woo_variable, woo_agrupado, InHabilitado) values(" + "'" + idarticulo.Text + "'" + "," + "'" + idarticulo.Text + "'" + "," + "'" + nombre.Text + "'" + "," + "'" + rubro.SelectedValue.ToString() + "'" + "," + "'" + subrubro.SelectedValue.ToString() + "'" + "," + "'" + umedida.Text + "'" + "," + "'" + codeqvuiv.Text + "'" + "," + "'" + alto.Text + "'" + "," + "'" + ancho.Text + "'" + "," + "'" + peso.Text + "'" + "," + "'" + "0001" + "'" + ",";
            Csqlipbasico = Csqlipbasico + "'" + txtdetalle.Text + "'" + "," + Convert.ToInt16(CBweb.Checked) + ",";
            Csqlipbasico = Csqlipbasico + Convert.ToInt16(CBvariable.Checked) + "," + Convert.ToInt16(CBgroup.Checked) + "," + Convert.ToInt16(InHabilitado.Checked) + ")";
            string Csqlipreciob = "insert into precios(idarticulobarra, idarticulo, idlista, precio, porcentaje, idmoneda) values (" + "'" + idarticulo.Text + "'" + "," + "'" + idarticulo.Text + "'" + "," + "'" + ConfigData.Rows[0]["SHOPPRICELIST"].ToString() + "'" + "," + "'" + precio.Text + "'" + "," + "'" + "0" + "'" + "," + "'" + ConfigData.Rows[0]["SHOPIDMONEDA"].ToString() + "'" + ")";
            string Csqlistock = "insert into stock (idarticulobarra, idarticulo, iddeposito, cantidad) values (" + "'" + idarticulo.Text + "'" + "," + "'" + idarticulo.Text + "'" + "," + "'" + ConfigData.Rows[0]["SHOPSTOCKID"].ToString() + "'" + "," + "'" + cantidad.Text + "'" + ")";


            


            /* Con esta logica, se obtiene el valor y el nombre de cada elemento del checklistbox */
            for (int i = 0; i < listarubros.Items.Count; i++)
            {
                        
                DataRowView r = (DataRowView)listarubros.Items[i];
                string val = (r[listarubros.ValueMember]).ToString();
                string dis = (r[listarubros.DisplayMember]).ToString();
                r = null;
                string Csqldrubros = "delete from rubrosarticulos where idarticulo='" + idarticulo.Text + "'" + "and idrubro='" + val + "'";
                if (listarubros.GetItemCheckState(i) == CheckState.Checked)
                {            
                    cmd = new SqlCommand(Csqldrubros, cnn);
                    cmd.ExecuteNonQuery();
                    string Csqlirubros = "insert into rubrosarticulos (idarticulo, idrubro) values(" + "'" + idarticulo.Text + "'" + "," + "'" + val + "'" + ")";
                    cmd = new SqlCommand(Csqlirubros, cnn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd = new SqlCommand(Csqldrubros, cnn);
                    cmd.ExecuteNonQuery();
                }
            }




            try
            {

                //comando para hacer sentencias en sql
                cmd = new SqlCommand(Csqlipbasico, cnn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(Csqlipreciob, cnn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(Csqllistaartd, cnn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(Csqlistock, cnn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(cSqldelete, cnn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(cSqlinserttags, cnn);
                cmd.ExecuteNonQuery();


                for (int i = 0; i < lista2.Items.Count; i++)
                {
                    string Cadena = lista2.Items[i].ToString();
                    int nLargo = Cadena.Length;
                    int cValor = Cadena.IndexOf('?') + 1;
                    string id = Cadena.Substring(cValor, nLargo - cValor);

                    string Csqllistaarti = "insert into ARTICULOSJERARQUIAS (idarticulo, idarticulofather) values(" + "'" + id + "'" + "," + "'" + idarticulo.Text + "'" + ")";
                    cmd = new SqlCommand(Csqllistaarti, cnn);
                    cmd.ExecuteNonQuery();
                }

                


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo grabar el producto:" + ex.ToString());
            }


            MessageBox.Show("Se grabo correctamente");

        }

        public void Modificarproductos(TextBox idarticulo, TextBox txttags, TextBox txtdetalle, CheckBox CBweb, CheckBox CBgroup, CheckBox CBvariable, CheckedListBox listarubros, ListBox lista2, ListBox lista1, TextBox nombre, ComboBox rubro, ComboBox subrubro, TextBox umedida, TextBox codeqvuiv, TextBox alto, TextBox ancho, TextBox peso, TextBox precio, TextBox cantidad, CheckBox InHabilitado)
        {
            DataTable ConfigData = new DataTable();
            string sql = "Select * From Configuracion";
            SqlCommand cmd = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ConfigData);

            string Csqlbasico = "update articulos set nombre='" + nombre.Text + "'" + ",";
            Csqlbasico = Csqlbasico + "idrubro='" + rubro.SelectedValue.ToString() + "'" + ",";
            Csqlbasico = Csqlbasico + "idsubrubro='" + subrubro.SelectedValue.ToString() + "'" + ",";
            Csqlbasico = Csqlbasico + "UniMedi='" + umedida.Text + "'" + ",";
            Csqlbasico = Csqlbasico + "codequiv='" + codeqvuiv.Text + "'" + ",";
            Csqlbasico = Csqlbasico + "alto='" + alto.Text + "'" + ",";
            Csqlbasico = Csqlbasico + "ancho='" + ancho.Text + "'" + ",";
            Csqlbasico = Csqlbasico + "peso='" + peso.Text + "'" + ",";
            Csqlbasico = Csqlbasico + "idclase='" + "0001" + "'" + "where idarticulo='" + idarticulo.Text + "'";
            string Csqlprecios = "update precios set precio ='" + precio.Text + "'" + ",";
            Csqlprecios = Csqlprecios + "idmoneda='" + ConfigData.Rows[0]["SHOPIDMONEDA"].ToString() + "'" + "where idarticulo = '" + idarticulo.Text + "'";
            string Csqlstock = "update stock set iddeposito='" + ConfigData.Rows[0]["SHOPSTOCKID"].ToString() + "'" + ",";
            Csqlstock = Csqlstock + "cantidad='" + cantidad.Text + "'" + "where idarticulo ='" + idarticulo.Text + "'";
            string Csqlcheckbox = "update articulos set WOO_DETALLE='" + txtdetalle.Text + "'" + ",";
            Csqlcheckbox = Csqlcheckbox + "publicarweb=" + Convert.ToInt16(CBweb.Checked) + ",";
            Csqlcheckbox = Csqlcheckbox + "woo_variable=" + Convert.ToInt16(CBvariable.Checked) + ",";
            Csqlcheckbox = Csqlcheckbox + "woo_agrupado=" + Convert.ToInt16(CBgroup.Checked) + "," + "InHabilitado=" + Convert.ToInt16(InHabilitado.Checked) + "where idarticulo='" + idarticulo.Text + "'";
            string cSqldeletetags = "delete from ecomm_tags  where idarticulo ='" + idarticulo.Text + "'";
            string cSqlinserttags = "insert into ecomm_tags (idarticulo, tags) values(" + "'" + idarticulo.Text + "'" + "," + "'" + txttags.Text + "'" + ")";
            string Csqllistaartd = "delete from ARTICULOSJERARQUIAS where IDARTICULOFATHER='" + idarticulo.Text + "'";




            for (int i = 0; i < listarubros.Items.Count; i++)
            {

                DataRowView r = (DataRowView)listarubros.Items[i];
                string val = (r[listarubros.ValueMember]).ToString();
                string dis = (r[listarubros.DisplayMember]).ToString();
                r = null;
                string Csqldrubros = "delete from rubrosarticulos where idarticulo='" + idarticulo.Text + "'" + "and idrubro='" + val + "'";
                if (listarubros.GetItemCheckState(i) == CheckState.Checked)
                {
                    cmd = new SqlCommand(Csqldrubros, cnn);
                    cmd.ExecuteNonQuery();
                    string Csqlirubros = "insert into rubrosarticulos (idarticulo, idrubro) values(" + "'" + idarticulo.Text + "'" + "," + "'" + val + "'" + ")";
                    cmd = new SqlCommand(Csqlirubros, cnn);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd = new SqlCommand(Csqldrubros, cnn);
                    cmd.ExecuteNonQuery();
                }
            }


            try
            {
                cmd = new SqlCommand(Csqlbasico, cnn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(Csqlprecios, cnn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(Csqlstock, cnn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(Csqlcheckbox, cnn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(cSqldeletetags, cnn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(cSqlinserttags, cnn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(Csqllistaartd, cnn);
                cmd.ExecuteNonQuery();


                for (int i = 0; i < lista2.Items.Count; i++)
                {
                    string Cadena = lista2.Items[i].ToString();
                    int nLargo = Cadena.Length;
                    int cValor = Cadena.IndexOf('?') + 1;
                    string id = Cadena.Substring(cValor, nLargo - cValor);

                    string Csqllistaarti = "insert into ARTICULOSJERARQUIAS (idarticulo, idarticulofather) values(" + "'" + id + "'" + "," + "'" + idarticulo.Text + "'" + ")";
                    cmd = new SqlCommand(Csqllistaarti, cnn);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Modificado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar el producto:" + ex.ToString());
            }
        }

        public void Llenarconfiguracion(ComboBox cblista, ComboBox cbvendedor, ComboBox cbstock, ComboBox cbmoneda, CheckBox Chbox, TextBox imagen)
        {
            string Csqllista = "select Nombre, idLista from listas order by Nombre";
            string Csqlvendedor = "select Nombre, idVendedor from vendedores order by Nombre";
            string Csqldeposito = "select Nombre, idDeposito from depositos order by Nombre";
            string Csqlmoneda = "select Nombre, idMoneda from monedas order by Nombre";
            string Csqlconfiguracion = "select isnull(WOO_BACKORDER,0) as WOO_BACKORDER, WOO_IMAGES, SHOPPRICELIST, SHOPSELLER, SHOPSTOCKID, SHOPIDMONEDA from configuracion";

            try
            {
                
                cmd = new SqlCommand(Csqlconfiguracion, cnn);
                SqlDataReader Rconfiguracion = cmd.ExecuteReader();
                //lista
                da = new SqlDataAdapter(Csqllista, cnn);
                DataTable lista = new DataTable();
                da.Fill(lista);
                //vendedor
                da = new SqlDataAdapter(Csqlvendedor, cnn);
                DataTable vendedor = new DataTable();
                da.Fill(vendedor);
                //stock
                da = new SqlDataAdapter(Csqldeposito, cnn);
                DataTable stock = new DataTable();
                da.Fill(stock);
                //moneda
                da = new SqlDataAdapter(Csqlmoneda, cnn);
                DataTable moneda = new DataTable();
                da.Fill(moneda);
                //Llenar listas
                cblista.DisplayMember = "Nombre";
                cblista.ValueMember = "idLista";
                cblista.DataSource = lista;
                //Llenar vendedor
                cbvendedor.DisplayMember = "Nombre";
                cbvendedor.ValueMember = "idVendedor";
                cbvendedor.DataSource = vendedor;
                //Llenar deposito
                cbstock.DisplayMember = "Nombre";
                cbstock.ValueMember = "idDeposito";
                cbstock.DataSource = stock;
                //Llenar moneda
                cbmoneda.DisplayMember = "Nombre";
                cbmoneda.ValueMember = "idMoneda";
                cbmoneda.DataSource = moneda;
                //Llenar checkbox y tomar value config
                if (Rconfiguracion.Read() == true)
                {
                    Chbox.Checked = Convert.ToBoolean(Rconfiguracion["WOO_BACKORDER"]);
                    imagen.Text = Rconfiguracion["WOO_IMAGES"].ToString();
                    cblista.SelectedValue = Rconfiguracion["SHOPPRICELIST"];
                    cbvendedor.SelectedValue = Rconfiguracion["SHOPSELLER"];
                    cbstock.SelectedValue = Rconfiguracion["SHOPSTOCKID"];
                    cbmoneda.SelectedValue = Rconfiguracion["SHOPIDMONEDA"];
                }
                else
                {
                    Chbox.Checked = false;
                }
                Rconfiguracion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void config()
        {
            DataTable ConfigData = new DataTable();
            string sql = "Select * From Configuracion";
          //  try
         //   {
                SqlCommand cmd = new SqlCommand(sql, cnn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ConfigData);
         //   }
         //   catch (Exception e)
         //   {
         //
         //   }
            

            
        }
        public void Grabarconfiguracion(ComboBox cblista, ComboBox cbvendedor, ComboBox cbstock, ComboBox cbmoneda, CheckBox Chbox, TextBox imagen)
        {
            string Csqlcombobox = "update configuracion set SHOPPRICELIST ='" + cblista.SelectedValue.ToString() + "'" + ",";
            Csqlcombobox = Csqlcombobox + "SHOPSELLER='" + cbvendedor.SelectedValue.ToString() + "'" + ",";
            Csqlcombobox = Csqlcombobox + "SHOPSTOCKID='" + cbstock.SelectedValue.ToString() + "'" + ",";
            Csqlcombobox = Csqlcombobox + "SHOPIDMONEDA='" + cbmoneda.SelectedValue.ToString() + "'" + ",";
            Csqlcombobox = Csqlcombobox + "WOO_BACKORDER='" + Convert.ToInt16(Chbox.Checked) + "'" + ",";
            Csqlcombobox = Csqlcombobox + "WOO_IMAGES='" + imagen.Text + "'" + "from configuracion";

            try
            {
                cmd = new SqlCommand(Csqlcombobox, cnn);
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            MessageBox.Show("Se grabo con exito");
        }


        public void Cambiolista(ListBox Lista1, ListBox Lista2)
        {
            bool sihay = false;


            try
            {
                foreach(var item in Lista2.Items)
                {
                    if(item.ToString().Contains(Lista1.Text))
                    {
                        sihay = true;
                    }
                }
                if(sihay)
                {
                    MessageBox.Show("Este articulo ya fue ingresado");
                }
                else
                {
                    for (int i = 0; i < Lista1.Items.Count; i++)
                    {

                        DataRowView r = (DataRowView)Lista1.Items[i];
                        string val = (r[Lista1.ValueMember]).ToString();
                        string dis = (r[Lista1.DisplayMember]).ToString();
                        if(Lista1.SelectedValue.ToString() == val)
                        {
                            Lista2.Items.Add(Lista1.Text +""+"?"+""+ Lista1.SelectedValue.ToString().Trim());
                        }
                    }
                    
                }
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }  
        
        public void LLenardatagridr(DataGridView dgv)
        {
            try
            {
                string datagridr = "select idrubro as Codigo, Nombre from rubros";
                da = new SqlDataAdapter(datagridr, cnn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo llenar la tabla" + ex.ToString());
            }
        }

        public void LLenarJerarquiaderubros(CheckedListBox listarubros, TextBox cajaidrubro)
        {
            

            DataTable dt = new DataTable();

            string consultarubros = "select idRubro, Nombre from rubros order by nombre asc";
            cmd = new SqlCommand(consultarubros, cnn);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            listarubros.DataSource = dt;
            listarubros.DisplayMember = "Nombre";
            listarubros.ValueMember = "idRubro";


            string Csql = "select * from RUBROSJERARQUIAS where idrubrofather ='" + cajaidrubro.Text + "'";
            cmd = new SqlCommand(Csql, cnn);
            SqlDataReader read = cmd.ExecuteReader();

            if (read.HasRows)
            {
                while (read.Read())
                {
                    /* Con esta logica, se obtiene el valor y el nombre de cada elemento del checklistbox */
                    for (int i = 0; i < listarubros.Items.Count; i++)
                    {
                        DataRowView r = (DataRowView)listarubros.Items[i];
                        string val = (r[listarubros.ValueMember]).ToString();
                        string dis = (r[listarubros.DisplayMember]).ToString();
                        r = null;
                        string idrubro = read["IdRubro"].ToString().Trim();

                        if (idrubro == val)
                        {
                            listarubros.SetItemChecked(i, true);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            read.Close();
           
        }

        public void Grabarjerarquia(CheckedListBox listarubros, TextBox cajaidrubro)
        {
            string Csql = "select IdRubro, idrubrofather from RUBROSJERARQUIAS where idrubrofather ='" + cajaidrubro.Text + "'";


            try
            {
                cmd = new SqlCommand(Csql, cnn);
                SqlDataReader read = cmd.ExecuteReader();

                /* Con esta logica, se obtiene el valor y el nombre de cada elemento del checklistbox */
                for (int i = 0; i < listarubros.Items.Count; i++)
                {

                    DataRowView r = (DataRowView)listarubros.Items[i];
                    string val = (r[listarubros.ValueMember]).ToString();
                    string dis = (r[listarubros.DisplayMember]).ToString();
                    r = null;
                    string Csqldrubros = "delete from RUBROSJERARQUIAS where idrubrofather='" + cajaidrubro.Text + "'" + "and IdRubro='" + val + "'";
                    if (listarubros.GetItemCheckState(i) == CheckState.Checked)
                    {
                        cmd = new SqlCommand(Csqldrubros, cnn);
                        cmd.ExecuteNonQuery();
                        string Csqlirubros = "insert into RUBROSJERARQUIAS (IdRubro, idrubrofather) values(" + "'" + val + "'" + "," + "'" + cajaidrubro.Text + "'" + ")";
                        cmd = new SqlCommand(Csqlirubros, cnn);
                        cmd.ExecuteNonQuery();
                    }
                    else
                    {
                        cmd = new SqlCommand(Csqldrubros, cnn);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al grabar" + ex.ToString());
            }
            MessageBox.Show("Se grabo correctamente");
        }

        public void sync(Label sync0, Label sync1)
        {
            string Csqlsync0 = "select count(idarticulo) sync from articulos a left join rubros r on r.idrubro = a.idrubro left join subrubros s on s.IdSubRubro = a.IdSubRubro where r.publicarweb = 1 and a.inhabilitado = 0 and s.PUBLICARWEB = 1 and a.PUBLICARWEB = 1 and sync = 0";
            string Csqlsync1 = "select count(idarticulo) sync from articulos a left join rubros r on r.idrubro = a.idrubro left join subrubros s on s.IdSubRubro = a.IdSubRubro where r.publicarweb = 1 and a.inhabilitado = 0 and s.PUBLICARWEB = 1 and a.PUBLICARWEB = 1 and sync = 1";

            try
            {
                cmd = new SqlCommand(Csqlsync0, cnn);
                SqlDataReader Sync0 = cmd.ExecuteReader();
                cmd = new SqlCommand(Csqlsync1, cnn);
                SqlDataReader Sync1 = cmd.ExecuteReader();

                if (Sync0.Read() == true)
                {
                    sync0.Text = Sync0["sync"].ToString();
                   
                }
                else
                {

                }
                if (Sync1.Read() == true)
                {
                    sync1.Text = Sync1["sync"].ToString();
                }
                else
                {

                }
            }
            catch(Exception)
            {
                MessageBox.Show("Fallo la funcion de sincronizacion");
            }
        }

        public void FormatoMoneda(TextBox xTBox)
        {
            if (xTBox.Text == string.Empty)
            {
                return;
            }
            else
            {
                decimal Monto;

                Monto = Convert.ToDecimal(xTBox.Text);
                xTBox.Text = Monto.ToString("N2");

            }
        }

        public void Solonumeros(KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {

                e.Handled = true;

                return;
            }
        }

        public void Completarcon0(TextBox Codigo, TextBox codigo2)
        {
            string Csql = "select artnumerico,LongCodArt from configuracion";
            cmd = new SqlCommand(Csql, cnn);
            SqlDataReader read = cmd.ExecuteReader();
            if (read.Read() == true)
            {
                string cuantos0 = read["LongCodArt"].ToString();
                string zeros;
                zeros = new string('0', Convert.ToInt32(cuantos0));

                Codigo.Text = string.Format("{0:" + zeros + "}", Convert.ToInt32(codigo2.Text));
            }
            
        }

        public void rubroysub(ComboBox rubro, ComboBox subrubo)
        {
            DataTable dt = new DataTable();

            string consultarubros = "select idRubro, Nombre from rubros order by nombre asc";
            cmd = new SqlCommand(consultarubros, cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            rubro.DataSource = dt;
            rubro.DisplayMember = "Nombre";
            rubro.ValueMember = "idRubro";

            DataTable dt1 = new DataTable();

            string consultasubrubros = "select idsubRubro, Nombre from subrubros order by nombre asc";
            cmd = new SqlCommand(consultasubrubros, cnn);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            da1.Fill(dt1);

            subrubo.DataSource = dt1;
            subrubo.DisplayMember = "Nombre";
            subrubo.ValueMember = "idsubRubro";
        }

        public void Codigoregistrado(TextBox Textbox1)
        {
            string query = "Select COUNT(*) from articulos WHERE idarticulo = @param";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@param", Textbox1.Text);

            int cant = Convert.ToInt32(cmd.ExecuteScalar());

            if (cant == 0)
            {
                    
            }
            else
            {
                MessageBox.Show("El articulo ya existe");
                Textbox1.Text = "";
                Textbox1.Focus();
                return;
            }
        }

        public void Rubroregistrado(TextBox Textbox1)
        {
            string query = "Select COUNT(*) from rubros WHERE idrubro = @param";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@param", Textbox1.Text);

            int cant = Convert.ToInt32(cmd.ExecuteScalar());

            if (cant == 0)
            {

            }
            else
            {
                MessageBox.Show("El rubro ya existe");
                Textbox1.Text = "";
                Textbox1.Focus();
                return;
            }
        }

        public void Subrubroregistrado(TextBox Textbox1)
        {
            string query = "Select COUNT(*) from subrubros WHERE idsubrubro = @param";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@param", Textbox1.Text);

            int cant = Convert.ToInt32(cmd.ExecuteScalar());

            if (cant == 0)
            {

            }
            else
            {
                MessageBox.Show("El subrubro ya existe");
                Textbox1.Text = "";
                Textbox1.Focus();
                return;
            }
        }

        public void publicarwebr(TextBox cajaidarticulo, CheckBox publicarweb)
        {
            string CsqlCheck = "select isnull(publicarweb, 0) as publicarweb from rubros where idrubro ='" + cajaidarticulo.Text + "'";
            cmd = new SqlCommand(CsqlCheck, cnn);
            SqlDataReader read = cmd.ExecuteReader();


            if (read.Read() == true)
            {
                publicarweb.Checked = Convert.ToBoolean(read["publicarweb"]);
            }
            else
            {
                publicarweb.Checked = false;
            }
        }

        public void publicarwebsr(TextBox cajaidarticulo, CheckBox publicarweb)
        {
            string CsqlCheck = "select isnull(publicarweb, 0) as publicarweb from subrubros where idsubrubro ='" + cajaidarticulo.Text + "'";
            cmd = new SqlCommand(CsqlCheck, cnn);
            SqlDataReader read = cmd.ExecuteReader();


            if (read.Read() == true)
            {
                publicarweb.Checked = Convert.ToBoolean(read["publicarweb"]);
            }
            else
            {
                publicarweb.Checked = false;
            }
        }

        public void grabarrubros(TextBox idrubro, TextBox nombre, CheckBox cbpucliar)
        {
            string insert = "insert into rubros (idrubro, nombre, publicarweb) values (" + "'" + idrubro.Text + "'" + "," + "'" + nombre.Text + "'" + "," + Convert.ToInt16(cbpucliar.Checked) + ")";

            try
            {
                cmd = new SqlCommand(insert, cnn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("fue grabado con exito");
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo grabar el rubro:" + ex.ToString());
            }
        }

        public void grabarsubrubros(TextBox idsubrubro, TextBox nombre, CheckBox cbpucliar)
        {
            string insert = "insert into subrubros (idsubrubro, nombre, publicarweb) values (" + "'" + idsubrubro.Text + "'" + "," + "'" + nombre.Text + "'" + "," + Convert.ToInt16(cbpucliar.Checked) + ")";

            try
            {
                cmd = new SqlCommand(insert, cnn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("fue grabado con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo grabar el subrubro:" + ex.ToString());
            }
        }

        public void modificarrubros(TextBox idrubro, TextBox nombre, CheckBox cbpublicar)
        {
            string update = "update rubros set nombre ='" + nombre.Text + "'" + "," + "publicarweb=" + Convert.ToInt16(cbpublicar.Checked) + "where idrubro='" + idrubro.Text + "'";

            try
            {
                cmd = new SqlCommand(update, cnn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Se modifico correctamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo modificar el rubro:" + ex.ToString());
            }
        }

        public void modificarsubrubros(TextBox idsubrubro, TextBox nombre, CheckBox cbpublicar)
        {
            string update = "update subrubros set nombre ='" + nombre.Text + "'" + "," + "publicarweb=" + Convert.ToInt16(cbpublicar.Checked) + "where idsubrubro='" + idsubrubro.Text + "'";

            try
            {
                cmd = new SqlCommand(update, cnn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Se modifico correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo modificar el subrubro:" + ex.ToString());
            }
        }
    }
}

