using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Controlador
{
    public class cDia : cEntidad
    {
        public cDia():base ("TDia")
        {}

        public override string[] NombresAtributos()
        {
            return new string[] { "CodDia", "Dia"};

        }
            
    }
}
