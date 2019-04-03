using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Modelo;

namespace Controlador
{
    public abstract class cEntidad
    {
        #region atributos

        protected cConexion aConexion;
        private string aNombreTabla;
        string[] aNombres = null;
        string[] aValores = null;
        private bool aNuevo;
        #endregion atributos
        

        #region Constructores

        public cEntidad(string pNombreTabla)
        {
            //Inicializar los atributos
            aNuevo = true;
            aNombreTabla = pNombreTabla;
            aConexion = new cConexion();
            aNombres = NombresAtributos();
            aValores = null;
        }
        #endregion Constructores

        #region propiedades
        public bool Nuevo
        {
            get { return aNuevo; }
            set { aNuevo = value; }
        }
        #endregion propiedades

        #region MetodosSoporteBD
        public abstract string[] NombresAtributos();

        #endregion MetodosSoporteBD


        #region MetodosAuxiliares

        private void VerificarResultadoInsercion()
        {
            if (ValorAtributo("CodError") == "0")
                aNuevo = true;
        }

        private string ValoresTabla()
        {
            string valorestabla = "";
            for (int k = 0; k < aValores.Length; k++)
            {
                valorestabla += aValores[k];
                if (k == aValores.Length - 1)
                    valorestabla += "'";
                else
                    valorestabla += "', '";
            }
            return valorestabla;
        }

        private string Claveprimaria(params string[] Atributos){
            return Atributos[0];
        }
        #endregion MetodosAuxiliares

        #region MetodosMantenimientoBD

        public virtual void Insertar(params string[] Atributos){
            aValores = Atributos;
            string CadenaInsertar = "exec spu" + aNombreTabla + "_Insertar '" + ValoresTabla();
            try
            {
                aConexion.EjecutarSelect(CadenaInsertar);
                VerificarResultadoInsercion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error. " + ex.Message);
            }
            
            
        }

        public virtual void Actualizar(params string[] Atributos)
        {
            string CadenaActualizar = "exec spu" + aNombreTabla + "_Actualizar '" + ValoresTabla();
            try
            {
                aConexion.EjecutarSelect(CadenaActualizar);
                VerificarResultadoInsercion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error. " + ex.Message);
            }
            
        }

        public void Eliminar(params string[] Atributos)
        {
            aNombres = NombresAtributos();
            aValores = Atributos;
            string CadenaEliminar = "delete from " + aNombreTabla +
                                    " where " + Claveprimaria(aNombres) + "= '" + Claveprimaria(aValores) + "'";
            try
            {
                aConexion.EjecutarComando(CadenaEliminar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error. " + ex.Message);
            }
            
        }

        public bool ExisteClavePrimaria(params string[] Atributos)
        {
            aNombres = NombresAtributos();
            aValores = Atributos;
            string CadenaConsulta = "select * from " + aNombreTabla +
                                    " where " + Claveprimaria(aNombres) + "= '" + Claveprimaria(aValores) + "'";
            try
            {
                aConexion.EjecutarSelect(CadenaConsulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error. " + ex.Message);
            }
            return (aConexion.Datos.Tables[0].Rows.Count > 0);
            
        }
        //---------------------------------------------------------------------------------
        public DataTable Registro(params string[] Atributos)
        {
            aNombres = NombresAtributos();
            aValores = Atributos;
            string CadenaConsulta = "select * from " + aNombreTabla +
                                    " where " + Claveprimaria(aNombres) + "= '" + Claveprimaria(aValores) + "'";
            try
            {
                aConexion.EjecutarSelect(CadenaConsulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error. " + ex.Message);
            }
            
            return aConexion.Datos.Tables[0];
        }
        //-------------------------------------------------------------------------
        public string ValorAtributo(string pNombreCampo)
        {
            return aConexion.Datos.Tables[0].Rows[0][pNombreCampo].ToString();
        }
        //------------------------------------------------------------------------
        public DataTable ListaGeneral()
        {

            string Consulta = "exec spu" + aNombreTabla + "_Listar";
            try
            {
                aConexion.EjecutarSelect(Consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error. " + ex.Message);
            }
            

            return aConexion.Datos.Tables[0];
        }
        #endregion MetodosMantenimientoBD

    }
}
