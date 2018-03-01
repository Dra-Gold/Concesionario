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

namespace Login
{
    public partial class IngreUsu : Form
    {
        public IngreUsu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            cboPermisos.Items.Clear();
            cboPermisos.Items.Add("Usuario Normal");
            cboPermisos.Items.Add("Administrador");
            cboPermisos.SelectedIndex = 0;
            txtusuario.Focus();
        }

        private void IngreUsu_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            string usus=  txtusuario.Text;
            string pass = txtpass.Text;
            int a = 0;
            if(cboPermisos.SelectedIndex == 0)
            {
                a = 0;
            }
            else
            {
                a = 1;
            }
            if (txtusuario.Text == "")
            {
                MessageBox.Show("Ingrese un Usuario");
            }
            if (txtpass.Text == "")
            {
                MessageBox.Show("Ingrese una Password");
            }
            else
            {
                try
                {
                    SqlConnection cnn = new SqlConnection("Server= localhost ; database=master; integrated security=yes");
                    string usu = "insert into [Concesionariadatos].[dbo].[Logeo] values('" + usus + "','" + pass + "'," + a + ")";
                    SqlCommand cmd = new SqlCommand(usu, cnn);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usted Ingreso Un Usuario Correctamente");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error sql", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            
        }
    }
}
