using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Controlador
{
    public class cUsuario : cEntidad
    {
        public cUsuario()
            : base("TUsuario")
        { }

        public override string[] NombresAtributos()
        {
            return new string[] { "Usuario", "Contraseña" };

        }

    }
}
