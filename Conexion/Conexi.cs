using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Conexion
{
  public   class Conexi
    {

        private SqlDataReader m_dr;
        private SqlCommand cmd;
        private string m_stringConexion;
        private SqlConnection m_cnn;

        public Conexi()
        {
            m_stringConexion = "Data Source=localhost ;Initial Catalog=master ;Integrated Security=True";
            m_cnn = new SqlConnection(m_stringConexion);
        }

        public Conexi(string cadenaConexion)
        {
            m_stringConexion = cadenaConexion;
            m_cnn = new SqlConnection(m_stringConexion);
        }


        public SqlDataReader Dr
        {
            get
            {
                return m_dr;
            }

            set
            {
                m_dr = value;
            }
        }

        public SqlCommand Cmd
        {
            get
            {
                return cmd;
            }

            set
            {
                cmd = value;
            }
        }

        public string StringConexion
        {
            get
            {
                return m_stringConexion;
            }

            set
            {
                m_stringConexion = value;
            }
        }

        public SqlConnection Cnn
        {
            get
            {
                return m_cnn;
            }

            set
            {
                m_cnn = value;
            }
        }
        public void Consulta(string query)
        {
            
                if (Cnn.State == System.Data.ConnectionState.Open)
                {
                    cmd = new SqlCommand(query, m_cnn);
                    Dr.Close();
                    Dr = cmd.ExecuteReader();
                }
                else
                {
                    m_cnn.Open();
                    cmd = new SqlCommand(query, m_cnn);
                    Dr = cmd.ExecuteReader();
                }
            
            
        }

        public void Cerrar()
        {
            
                Dr.Close();
                m_cnn.Close();
           
            
            
        }

        public int Agregar(Ventas v)
        {
            if (v != null)
            {
                Consulta("insert into [Concesionariadatos].[dbo].[ventas] ([Rut],[Tipo_Vehiculo],[Marca],[Modelo],[Arancel],[Dias_Arriendo],[Total]) values ('" + v.Rut + "','" + v.TipoVehiculo + "','" + v.Marca + "','" + v.Modelo + "'," + v.Arancel + "," + v.DiasArriendo + "," + v.Total + ")");
                return 1;
            }
            return 0;
        }

        
    }
}
