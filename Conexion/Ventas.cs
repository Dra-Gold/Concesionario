using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{
   public class Ventas
    {
        private string rut;
        private string tipoVehiculo;
        private string marca;
        private string modelo;
        private int arancel;
        private int diasArriendo;
        private int total;

        private void Init()
        {
            this.rut = string.Empty;
            this.tipoVehiculo = string.Empty;
            this.marca = string.Empty;
            this.modelo = string.Empty;
            this.arancel = 0;
            this.diasArriendo = 0;
            this.total = 0;

        }

        public Ventas()
        {
            Init();
        }

        public Ventas(string rut, string tipoVehiculo, string marca, string modelo, int arancel, int diasArriendo, int total)
        {
            Rut = rut;
            TipoVehiculo = tipoVehiculo;
            Marca = marca;
            Modelo = modelo;
            Arancel = arancel;
            DiasArriendo = diasArriendo;
            Total = total;
        }

        public string Rut
        {
            get
            {
                return rut;
            }

            set
            { if (value.Trim().Length == 12)
                {
                    rut = value;
                }
                else
                {
                    throw new ArgumentException("El Rut debe tener 12 digitos Ejem: 11.111.111-1");
                }

            }
        }

        public string TipoVehiculo
        {
            get
            {
                return tipoVehiculo;
            }

            set
            {
                tipoVehiculo = value;
            }
        }

        public string Marca
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public string Modelo
        {
            get
            {
                return modelo;
            }

            set
            {
                modelo = value;
            }
        }

        public int Arancel
        {
            get
            {
                return arancel;
            }

            set
            {
                if (value > 0)
                {
                    arancel = value;
                }else
                {
                    throw new ArgumentException("El Arancel no puede ser 0");
                }
                   
            }
        }

        public int DiasArriendo
        {
            get
            {
                return diasArriendo;
            }

            set
            {
                if (value > 0)
                {
                    diasArriendo = value;
                }else
                {
                    throw new ArgumentException("Los Dias de Arriendo no pueden ser  0");
                }


            }
        }

        public int Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }
    }
}
