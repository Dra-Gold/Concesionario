using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion;
using System.Data.SqlClient;

namespace Login
{
    public partial class Ingreso : Form
    {
        Conexi con = new Conexi();
        public Ingreso()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            cbxMarca.Enabled = false;
            cbxModelo.Enabled = false;
            txtRut.ReadOnly = true;
            txtArriendo.ReadOnly = true;
            txtArancel.ReadOnly = true;
            txtTotal.ReadOnly = true;
            btnAgregar.Enabled = false;   
            btnLimpiar.Enabled = false;

            SqlConnection cnn = new SqlConnection("Server= localhost ; database=master; integrated security=yes");
            string cont = "select count(rut) from [Concesionariadatos].[dbo].[ventas]";
            SqlCommand cmd = new SqlCommand(cont, cnn);
            try
            {
                cnn.Open();
                label10.Text =Convert.ToString(cmd.ExecuteScalar());
              
            }
            catch (SqlException ex)
            {
                label10.Text = "0";
            }


        }

        private void cbxVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxVehiculos.SelectedIndex.Equals(0) || cbxVehiculos.SelectedIndex.Equals(1))
            {
                if (cbxVehiculos.SelectedIndex == 0)
                {
                    cbxMarca.Enabled = true;

                    cbxMarca.Items.Clear();
                    cbxMarca.Items.Add("Lamborghini");
                    cbxMarca.Items.Add("Ferrari");
                }

                if (cbxVehiculos.SelectedIndex == 1)
                {
                    cbxMarca.Enabled = true;
                    cbxMarca.Items.Clear();
                    cbxMarca.Items.Add("Chevrolet");
                    cbxMarca.Items.Add("Mazda");
                }
            }
            else
            {
                MessageBox.Show("Eliga una Opcion");
            }
        }

        private void cbxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxVehiculos.SelectedItem.Equals("Deportivo"))
            {
                if (cbxMarca.SelectedIndex.Equals(0) || cbxMarca.SelectedIndex.Equals(1))
                {
                    if (cbxMarca.SelectedIndex == 0)
                    {

                        cbxModelo.Enabled = true;

                        cbxModelo.Items.Clear();
                        cbxModelo.Items.Add("Lamborghini Aventador");
                        cbxModelo.Items.Add("Lamborghini Sesto Elemento");

                    }

                    if (cbxMarca.SelectedIndex == 1)
                    {
                        cbxModelo.Enabled = true;

                        cbxModelo.Items.Clear();
                        cbxModelo.Items.Add("Ferrari 250");
                        cbxModelo.Items.Add("Ferrari Dino");
                    }

                }
            }

            if (cbxVehiculos.SelectedItem.Equals("Familiar"))
            {
                if (cbxMarca.SelectedIndex.Equals(0) || cbxMarca.SelectedIndex.Equals(1))
                {
                    if (cbxMarca.SelectedIndex == 0)
                    {

                        cbxModelo.Enabled = true;

                        cbxModelo.Items.Clear();
                        cbxModelo.Items.Add("Corsa");
                        cbxModelo.Items.Add("Monte Carlo");

                    }

                    if (cbxMarca.SelectedIndex == 1)
                    {
                        cbxModelo.Enabled = true;

                        cbxModelo.Items.Clear();
                        cbxModelo.Items.Add("Fudai");
                        cbxModelo.Items.Add("Demio");
                    }

                }
            }
        }

        private void cbxModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMarca.SelectedItem.Equals("Lamborghini"))
            {
                if (cbxModelo.SelectedIndex.Equals(0) || cbxModelo.SelectedIndex.Equals(1))
                {
                    if (cbxModelo.SelectedIndex == 0)
                    {
                        txtRut.ReadOnly = false;
                        
                       
                    }

                    if (cbxModelo.SelectedIndex == 1)
                    {
                        txtRut.ReadOnly = false;
                       
                   
                    }
                }
            }

            if (cbxMarca.SelectedItem.Equals("Ferrari"))
            {
                if (cbxModelo.SelectedIndex.Equals(0) || cbxModelo.SelectedIndex.Equals(1))
                {
                    if (cbxModelo.SelectedIndex == 0)
                    {
                        txtRut.ReadOnly = false;
                      
                      
                    }

                    if (cbxModelo.SelectedIndex == 1)
                    {
                        txtRut.ReadOnly = false;
                       
                      
                    }
                }
            }

            if (cbxMarca.SelectedItem.Equals("Chevrolet"))
            {
                if (cbxModelo.SelectedIndex.Equals(0) || cbxModelo.SelectedIndex.Equals(1))
                {
                    if (cbxModelo.SelectedIndex == 0)
                    {
                        txtRut.ReadOnly = false;
                       
                       
                    }

                    if (cbxModelo.SelectedIndex == 1)
                    {
                        txtRut.ReadOnly = false;
                   
                    
                    }
                }
            }

            if (cbxMarca.SelectedItem.Equals("Mazda"))
            {
                if (cbxModelo.SelectedIndex.Equals(0) || cbxModelo.SelectedIndex.Equals(1))
                {
                    if (cbxModelo.SelectedIndex == 0)
                    {
                        txtRut.ReadOnly = false;
                
                     
                    }

                    if (cbxModelo.SelectedIndex == 1)
                    {
                        txtRut.ReadOnly = false;
                     
                       
                    }
                }
            }
        }

        private void Ingreso_Load(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            log l = new log();
            l.Show();
            this.Dispose(false);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar c = new Consultar();
            c.Show();
            this.Dispose(false);
        }

        private void Ingreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string rut = txtRut.Text;
            Boolean creacion = false;

            try
            {
                Ventas pc = new Ventas();
                pc.Rut = txtRut.Text;
                pc.TipoVehiculo = cbxVehiculos.SelectedItem.ToString();
                pc.Marca = cbxMarca.SelectedItem.ToString();
                pc.Modelo = cbxModelo.SelectedItem.ToString();

                int aux = 0;

                int.TryParse(txtArancel.Text, out aux);
                pc.Arancel = (int)aux;
                int.TryParse(txtArriendo.Text, out aux);
                pc.DiasArriendo = (int)aux;
                int.TryParse(txtTotal.Text, out aux);
                pc.Total = (int)aux;
                if (con.Agregar(pc) == 1)
                {
                    MessageBox.Show("Se ha agregado correctamente");
                    SqlConnection cnn = new SqlConnection("Server= localhost ; database=master; integrated security=yes");
                    string cont = "select count(rut) from [Concesionariadatos].[dbo].[ventas]";
                    SqlCommand cmd = new SqlCommand(cont, cnn);
                    try
                    {
                        cnn.Open();
                        label10.Text = Convert.ToString(cmd.ExecuteScalar());

                    }
                    catch (SqlException ex)
                    {
                        label10.Text = "0";
                    }
                    catch (System.NullReferenceException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No se han agregado los datos");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error, " + ex.Message);
            }
            catch (SqlException ex)
            {
                
                    MessageBox.Show("Error SQL " + ex.Message);
                if (ex.Number == 208)
                {
                    creacion = true;
                    MessageBox.Show(null, "La Tabla  No Existe ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (creacion)
                    {
                        if (MessageBox.Show(null, "Desea Crear la Tabla ", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            SqlConnection cnn = new SqlConnection("Server= localhost ; database=master; integrated security=yes");
                            string tabla = "create table[Concesionariadatos].[dbo].[ventas](Rut char(12) ,Tipo_Vehiculo varchar(30),Marca varchar(30),Modelo varchar(30),Arancel numeric(13),Dias_Arriendo numeric(3),Total numeric(16))";
                            SqlCommand cmd = new SqlCommand(tabla, cnn);
                            try
                            {
                                cnn.Open();
                                cmd.ExecuteNonQuery();
                                MessageBox.Show(null, "La Tabla se creo con existo por favor vuelva a ingresar los datos ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Ingreso s = new Ingreso();
                                s.Show();
                                this.Dispose(false);
                            }
                            catch (SqlException exx)
                            {
                                MessageBox.Show(exx.Message, "Error sql", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inseperado, " + ex.Message);
            }
           
        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtRut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txtArriendo.ReadOnly = false;
                txtArriendo.Focus();
            }
        }

        private void txtArriendo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txtArancel.ReadOnly = false;
                txtArancel.Focus();
            }
        }

        private void txtArancel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btnAgregar.Enabled = true;
                btnLimpiar.Enabled = true;
                int cantidad = 0;
                int precio = 0;
                int totalc = 0;
                int total = 0;
                int.TryParse(txtArriendo.Text, out cantidad);
                int.TryParse(txtArancel.Text, out precio);
                totalc = cantidad * 20000;
                total = totalc + precio;
                txtTotal.Text = total.ToString();
                btnAgregar.Focus();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRut.Text = "";
            txtArriendo.Text = "";
            txtArancel.Text = "";
            txtTotal.Text = "";
            txtRut.ReadOnly = true;
            txtArancel.ReadOnly = true;
            txtArriendo.ReadOnly = true;
            txtTotal.ReadOnly = true;
            cbxMarca.Enabled = false;
            cbxModelo.Enabled = false;
            btnAgregar.Enabled = false;
            btnLimpiar.Enabled = false;
            cbxVehiculos.Focus();
        }

        private void txtArancel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
