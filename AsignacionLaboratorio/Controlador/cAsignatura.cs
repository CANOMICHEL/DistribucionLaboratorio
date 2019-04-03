using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;
namespace Controlador
{
    
    public class cAsignatura:cEntidad
    {
        public cAsignatura():base ("TAsignatura")
        {}

        public override string[] NombresAtributos()
        {
            return new string[] { "CodAsignatura", "NombreAsignatura","Creditos","Categoria" };

        }

        public void Insertar()
        {
            //dt.InsertTAsignatura();
        }
            
    }
}
