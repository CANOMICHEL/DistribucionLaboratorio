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
        public cUsuario() { }

        public bool ValidarUsuario(string user,string Password)
        {
            var usuario = (from s in dc.TUsuario
                           where s.Usuario == user
                           select s).First();
            return (usuario.Contraseña==Password);


        }
    }
}
