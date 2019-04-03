using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Modelo
{
    public class cConexion
    {
        #region atributos
        private SqlConnection aConexion;
        private SqlDataAdapter aAdaptador;
        private DataSet aDatos;
        private cLectorXml lectorXML = new cLectorXml();
        #endregion atributos

        #region Metodos

        public cConexion()
        {
            RealizarConexion();
        }

        private void RealizarConexion()
        {

            aDatos = new DataSet();
            aAdaptador = new SqlDataAdapter();
            String CadenaConexion = lectorXML.cadenaConexion();
            try
            {
                aConexion = new SqlConnection(CadenaConexion);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex.Message);
                Application.Exit();
            }
        }
        #endregion Metodos

        #region Propiedades

        public SqlConnection Conexion { get { return aConexion; } }

        public SqlDataAdapter Adaptador { get { return aAdaptador; } }

        public DataSet Datos { get { return aDatos; } }

        #endregion propiedades

        #region servicios

        public virtual DataSet EjecutarSelect(string pConsulta)
        {
            aAdaptador.SelectCommand = new SqlCommand(pConsulta, aConexion);
            aDatos = new DataSet();
            try
            {
                aAdaptador.Fill(aDatos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex.Message);
            }
            return aDatos;
        }

        public virtual void EjecutarComando(string pComando)
        {
            SqlCommand oComando = new SqlCommand(pComando, aConexion);
            aConexion.Open();
            oComando.ExecuteNonQuery();
            aConexion.Close();
        }
        #endregion servicios

    }
}
