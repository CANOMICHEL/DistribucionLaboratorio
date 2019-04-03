using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Controlador
{
    public class cPrincipal : cEntidad
    {
        public cPrincipal()
            : base("TPrincipal")
        { }

        public override string[] NombresAtributos()
        {
            return new string[] { "CodDocente_Asignatura", "CodLaboratorio", "CodDia", "CodHorario" };

        }

    }
}
