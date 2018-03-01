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
using System.Security.Permissions;

namespace Login
{
    public partial class BackupBD : Form
    {
        public BackupBD()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void BackupBD_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre="";
            SaveFileDialog op = new SaveFileDialog();
            op.Filter = "Respaldo Base De Datos (*.BAK)|*.BAK";
            op.ShowDialog();
            nombre = op.FileName;
            if (nombre.Length!=0)
            {
                string sBackup = "BACKUP DATABASE Concesionariadatos TO DISK =N'" + nombre + "' WITH NOFORMAT, NOINIT, NAME =N'Concesionariadatos', SKIP, STATS = 10";
                using (SqlConnection con = new SqlConnection("Server= localhost ; database= master; integrated security=yes"))
                {
                    try
                    {
                        con.Open();

                        SqlCommand cmdBackUp = new SqlCommand(sBackup, con);

                        cmdBackUp.ExecuteNonQuery();

                        MessageBox.Show("Se ha creado un BackUp de La base de datos satisfactoriamente",
                            "Copia de seguridad de base de datos",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,
                            "Error al copiar la base de datos",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
            
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog alog = new OpenFileDialog();
            alog.Title ="Eliga Respaldo A Cargar";
            alog.Filter = "Respaldo Base De Datos (*.BAK)|*.BAK";
            alog.ShowDialog();
            string cargar = alog.FileName;
            

            if (cargar.Length != 0)
            {
                string sBackup = "RESTORE DATABASE Concesionariadatos from DISK =N'" + cargar + "' WITH REPLACE";
                string cerrar = "ALTER DATABASE Concesionariadatos SET OFFLINE WITH ROLLBACK IMMEDIATE";
                string abrir = "ALTER DATABASE Concesionariadatos SET online WITH ROLLBACK IMMEDIATE";

                using (SqlConnection con = new SqlConnection("Server= localhost ; database= master; integrated security=yes"))
                {
                    try
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        
                        con.Open();
                        
                        SqlCommand cmdBackUp = new SqlCommand(sBackup, con);
                        SqlCommand ce = new SqlCommand(cerrar, con);
                        SqlCommand abri = new SqlCommand(abrir, con);
                        ce.ExecuteNonQuery();
                        cmdBackUp.ExecuteNonQuery();
                        abri.ExecuteNonQuery();

                        MessageBox.Show("Se ha restaurado la copia de la base de datos",
                            "Restaurar base de datos",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,
                            "Error al restaurar la base de datos",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
