using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Controlador
{
    public class cLaboratorio : cEntidad
    {
        public cLaboratorio()
            : base("TLaboratorio")
        { }

        public override string[] NombresAtributos()
        {
            return new string[] { "CodLaboratorio", "NroLaboratorio" };

        }

    }
}
