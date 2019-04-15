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

        public bool ValidarUsuario(string Usuario,string Contra)
        {
            var usuario = dc.TUsuario1.FirstOrDefault(I => I.Usuario == Usuario);
            bool existe = false;
            try {
                existe = usuario.Contraseña == Contra;
            }
            catch(Exception e) {
            }
            return existe;
        }
    }
}
