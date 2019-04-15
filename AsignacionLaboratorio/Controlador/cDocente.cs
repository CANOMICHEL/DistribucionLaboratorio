using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;

namespace Controlador
{
    public class cDocente : cEntidad
    {
        
        public cDocente() { }

        public void Insertar(string Cod,string Nombre)
        {
            dc.spuTDocente_Insertar(Cod,Nombre);
        }
    }
}
