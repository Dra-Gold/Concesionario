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
using System.Data;
using System.IO;
using Conexion;
namespace Login
{
    public partial class log : Form
    {
        Conexi cdd =new Conexi();
        public static int inte = 3;
        public log()
           
        {
            string ins = inte.ToString();

            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            timer1.Enabled = true;
            txtPassword.ReadOnly = true;
            labIntentos.Text = ins;
            menuingreso.Enabled = false;
            menuArchivo.Enabled = false;
            menuAyuda.Enabled = true;
            menuAutor.Enabled = true;
            menuReiniciar.Enabled = true;
            menuSalir.Enabled = true;
            creacionbd();
            txtPassword.PasswordChar = '*';
            respaldoBaseDeDatosToolStripMenuItem.Enabled = false;
        }

        private void creacionbd()
        {
            Boolean creacion = false;
            try
            {
                SqlConnection cmm = new SqlConnection("Server= localhost ; database= Concesionariadatos; integrated security=True");
                cmm.Open();
            }
            catch (SqlException ex )
            {
                 if (ex.Number == 4060)
                {
                    creacion = true; 
                    MessageBox.Show(null, "La Base de Datos No Existe o es Incorrecta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            if (creacion)
            {
                if (MessageBox.Show(null, "Desea Crear la Base de Datos", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    SqlConnection cnn = new SqlConnection("Server= localhost ; database=master; integrated security=yes");
                    string s = "create database Concesionariadatos"; /*on primary" +*/
                        //"(NAME = Concesionaria_Data1, FILENAME = 'C:\\Archivos de programa\\Microsoft SQL Server\\Concesionariadatos1.mdf')" +
                        //"log on (NAME = Concesionaria_Log1, FILENAME = 'C:\\Archivos de programa\\Microsoft SQL Server\\Concesionariadatos1.ldf')";
                    string tabla = "create table [Concesionariadatos].[dbo].[Logeo](Usuario varchar(20) constraint pkUsuarioLogeo primary key(Usuario),Contraseña varchar(8),id numeric)";
                    string usu1= "insert into[Concesionariadatos].[dbo].[Logeo] values('Pedro', '123456', 1)";
                    string usu2= "insert into[Concesionariadatos].[dbo].[Logeo] values('Sebastian','123456',1)";
                    string usu3 = "insert into [Concesionariadatos].[dbo].[Logeo] values('Normal','654321',0)";
                    SqlCommand cmd = new SqlCommand(s, cnn);
                    SqlCommand cdd = new SqlCommand(tabla, cnn);
                    SqlCommand cusu1 = new SqlCommand(usu1, cnn);
                    SqlCommand cusu2 = new SqlCommand(usu2, cnn);
                    SqlCommand cusu3 = new SqlCommand(usu3, cnn);
                    try
                    {

                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cdd.ExecuteNonQuery();
                        cusu1.ExecuteNonQuery();
                        cusu2.ExecuteNonQuery();
                        cusu3.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Error al crear la base", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                    MessageBox.Show(null, "La Base de Datos a sido creada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }

        private void listadoYBusquedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar co = new Consultar();
            co.Show();
            this.Dispose(false);
        }

        private void arriendoDeVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ingreso i = new Ingreso();
            i.Show();
            this.Dispose(false);
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            labHora.Text = DateTime.Now.ToString("HH:MM:ss");
        }

        private void menuReiniciar_Click(object sender, EventArgs e)
        {
            log loga = new log();
            loga.Show();
            this.Dispose(false);
        }

        private void log_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void log_Load(object sender, EventArgs e)
        {
           
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            labCuenta.Text = txtUsuario.Text;
                
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (txtUsuario.Text == "")
                {
                    MessageBox.Show("Ingrese un Usuario");
                }
                else
                {
                    txtPassword.ReadOnly = false;
                    txtPassword.Focus();
                }
                
                    
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (txtPassword.Text == "")
                {
                    MessageBox.Show("Ingrese una Password");
                }
                else
                {
                    try
                    {
                        string usu = txtUsuario.Text;
                        string usu2;
                        string pass = txtPassword.Text;
                        string pass2;
                        int nu = 0;
                        string x="";
                        
                        cdd.Consulta("select Usuario from [Concesionariadatos].[dbo].[Logeo] where Usuario='" + usu + "'");
                        DataSet dsa = new DataSet();
                        SqlDataAdapter das = new SqlDataAdapter(cdd.Cmd);
                        cdd.Cerrar();
                        das.Fill(dsa, "[Logeo]");
                        usu2 = dsa.Tables[0].Rows[0]["Usuario"].ToString();
                        cdd.Consulta("select Contraseña from [Concesionariadatos].[dbo].[Logeo] where Contraseña='" + pass + "'");
                        SqlDataAdapter das1 = new SqlDataAdapter(cdd.Cmd);
                        DataSet dsa1 = new DataSet();
                        cdd.Cerrar();
                        das1.Fill(dsa1, "[Logeo]");
                        pass2 = dsa1.Tables[0].Rows[0]["Contraseña"].ToString();
                        
                        if (usu == usu2 && pass == pass2)
                        {
                            cdd.Consulta("select id from [Concesionariadatos].[dbo].[Logeo] where Usuario='" + usu + "'");
                            SqlDataAdapter das2 = new SqlDataAdapter(cdd.Cmd);
                            DataSet dsa2 = new DataSet();
                            cdd.Cerrar();
                            das2.Fill(dsa2, "[Logeo]");
                            x = dsa2.Tables[0].Rows[0]["Id"].ToString();
                            int.TryParse(x, out nu);
                            

                        }
                        if ((usu == usu2) && (pass == pass2) && (nu == 0))
                        {
                            MessageBox.Show(null, "Bienvenido usuario " + usu, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            menuArchivo.Enabled = true;
                            txtUsuario.ReadOnly = true;
                            txtPassword.ReadOnly = true;
                        }else if ((usu == usu2) && (pass == pass2) && (nu == 1))
                        {
                            MessageBox.Show(null, "Bienvenido Administrador "+usu, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            menuArchivo.Enabled = true;
                            menuingreso.Enabled = true;
                            txtUsuario.ReadOnly = true;
                            txtPassword.ReadOnly = true;
                            respaldoBaseDeDatosToolStripMenuItem.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show(null, "Error ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtPassword.Text = "";
                            txtUsuario.Text = "";
                            inte --;
                        }
                    }
                    catch (SqlException ex)
                {
                    MessageBox.Show(null, "Error Sql " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }catch(System.IndexOutOfRangeException ex)
                    {
                        MessageBox.Show(null, "Error de Usuario o Password incorrecta ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPassword.Text = "";
                        txtUsuario.Text = "";
                        txtPassword.ReadOnly = true;
                        txtUsuario.Focus();
                        inte--;
                        labIntentos.Text = inte.ToString();
                        if (inte==0)
                        {
                            MessageBox.Show(null, "Usted alcanzo el limite maximo de intentos  ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Application.Exit();
                        }
                    }

            }


            }
            }
        

        private void ingresarNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngreUsu s = new IngreUsu();
            s.Show();
        
        }

        private void menuAyuda_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(" Usuario 1: Pedro\n Contraseña: 123456\n --------------------------------\n Usuario 2: Normal\n Contraseña: 654321\n --------------------------------\n respete Mayusculas y Minusculas ", "Ayuda");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void respaldoBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackupBD su = new BackupBD();
            su.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuAutor_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Autor \n --------------------------------\n Pedro Millaquien\n --------------------------------\n Sebastian Acuña\n --------------------------------\n Seccion: 132 LunesT ", "Autor");
        }
    }
}
