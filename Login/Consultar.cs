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
using Conexion;
using System.IO;
using System.Security.Permissions;
using System.Security.AccessControl;
using System.Threading;

namespace Login
{
    public partial class Consultar : Form
    {
       static private bool yaEstoy__1;

       static private bool cancelar = false;

        Conexi con = new Conexi();
        public Consultar()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Consultar_Load(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            log l = new log();
            l.Show();
            this.Dispose(false);
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingreso da = new Ingreso();
            da.Show();
            this.Dispose(false);
        }

        private void Consultar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string textoCmd = "select * from [Concesionariadatos].[dbo].[ventas]";
                con.Consulta(textoCmd);
                SqlDataAdapter adapter = new SqlDataAdapter(con.Cmd);
                DataTable dt = new DataTable();
                con.Cerrar();
                adapter.Fill(dt);
                dvgVer.DataSource = dt;
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string textoCmd = "SELECT name FROM master.dbo.sysdatabases";
                con.Consulta(textoCmd);
                SqlDataAdapter adapter = new SqlDataAdapter(con.Cmd);
                DataTable dt = new DataTable();
                con.Cerrar();
                adapter.Fill(dt);
                dvgVer.DataSource = dt;
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

        private void button2_Click(object sender, EventArgs e)
        {try
            {
                string textoCmd = "select usuario, contraseña from [Concesionariadatos].[dbo].[Logeo]";
                con.Consulta(textoCmd);
                SqlDataAdapter adapter = new SqlDataAdapter(con.Cmd);

                DataTable dt = new DataTable();
                con.Cerrar();
                adapter.Fill(dt);
                dvgVer.DataSource = dt;
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

    private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection("Server= localhost ; database=master; integrated security=yes");
                string rut = textBox2.Text;
                string textoCmd = "select * from [Concesionariadatos].[dbo].[ventas] where  Rut like '"+rut+"%"+"'";
                SqlCommand cmd = new SqlCommand(textoCmd, cnn);
                cnn.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dvgVer.DataSource = dt;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection cnn = new SqlConnection("Server= localhost ; database=master; integrated security=yes");
                string total = textBox1.Text;
                string textoCmd = "select * from [Concesionariadatos].[dbo].[ventas] where  total like '" + total + "%" + "'";
                SqlCommand cmd = new SqlCommand(textoCmd, cnn);
                cnn.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dvgVer.DataSource = dt;
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string textoCmd = " select Logeo.Usuario ,Logeo.Contraseña, Logeo.id, ventas.rut, ventas.tipo_vehiculo, ventas.marca, ventas.modelo, ventas.Arancel, ventas.Dias_Arriendo, ventas.Total from [Concesionariadatos].[dbo].[Logeo] left join [Concesionariadatos].[dbo].[ventas] on Logeo.Usuario = ventas.Rut union " +
              " select Logeo.Usuario, Logeo.Contraseña, Logeo.id, ventas.rut, ventas.tipo_vehiculo, ventas.marca, ventas.modelo, ventas.Arancel," +
                "ventas.Dias_Arriendo, ventas.Total from  [Concesionariadatos].[dbo].[Logeo]  right join [Concesionariadatos].[dbo].[ventas]  on Logeo.Usuario = ventas.Rut";
                con.Consulta(textoCmd);
                SqlDataAdapter adapter = new SqlDataAdapter(con.Cmd);
                DataTable dt = new DataTable();
                con.Cerrar();
                adapter.Fill(dt);
                dvgVer.DataSource = dt;
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

        private void button4_Click(object sender, EventArgs e)
        {
            try{
                string textoCmd = "select ventas.rut,ventas.Dias_Arriendo,ventas.Total from [Concesionariadatos].[dbo].[ventas] ";
                con.Consulta(textoCmd);
                SqlDataAdapter adapter = new SqlDataAdapter(con.Cmd);

                DataTable dt = new DataTable();
                con.Cerrar();
                adapter.Fill(dt);
                dvgVer.DataSource = dt;
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
       
        

        private void button5_Click(object sender, EventArgs e)
        {
            if (yaEstoy__1)
            {
                cancelar = true;
                this.button5.Text = "Cancelando";
                Application.DoEvents();
                return;
            }
            yaEstoy__1 = true;

            DirectoryInfo di = new DirectoryInfo("c:\\");
            lvFics.Items.Clear();
            button5.Text = "Buscando ...";
            button5.Refresh();
            recorrerDir(di);
            this.Refresh();
            button5.Text = "Listar Todos Los Respaldos";
            cancelar = false;

            yaEstoy__1 = false;

        }


        private void recorrerDir(DirectoryInfo di)
        {
   
            FileInfo[] fics;
            DirectoryInfo[] dirs;

            Application.DoEvents();
            if (cancelar)
                return;
            try
            {
                fics = di.GetFiles("*.BAK*", SearchOption.TopDirectoryOnly);
                foreach (FileInfo fi in fics)
                {
                    ListViewItem lvi = this.lvFics.Items.Add(fi.Name);
                    lvi.SubItems.Add(fi.DirectoryName);
                }

                
                    dirs = di.GetDirectories();
                    foreach (DirectoryInfo dir in dirs)
                    {
                        recorrerDir(dir);
                    }
                
                
                
            }
            catch (Exception ex)
            {
                return;
                cancelar = true;
                Application.DoEvents();
            }
        }


    }
}
