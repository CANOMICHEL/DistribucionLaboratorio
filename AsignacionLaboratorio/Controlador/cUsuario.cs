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
            DataTable dt = new DataTable();
            try
            {
                var usuario = from user in dc.TUsuario
                              where user.Dni_Usuario == Usuario && user.Contraseña == Contra
                              select new{user.Dni_Usuario, };
                dt = ToDataTable(dc, usuario);
            }
            catch (Exception){ throw; }
            return dt.Rows.Count>0;
        }

        public DataTable TablaUsuario()
        {
            var vruser = from user in dc.TUsuario
                            select new { user.Dni_Usuario,user.Nombre,user.Apellido_Paterno,
                            user.Apellido_Materno};
            DataTable dt = ToDataTable(dc, vruser);
            return dt;
        }

        public void InsertarNuevoUsuario(string DNI,string Nombre,string AP,string AM,string contra,string Estado)
        {
            dc.spuTUsuario_Insertar(contra,Nombre,AP,AM,DNI,Estado);
        }

        public void ActualizarUsuario(string DNI, string Nombre, string AP, string AM, string contra, string Estado)
        {
            dc.spuTUsuario_Actualizar(contra, Nombre, AP, AM, DNI, Estado);
        }

        public string GenerarContraseña()
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            var value = random.Next(1, 9);
            string contra = value.ToString();
            for (int i = 0; i < 3; i++)
            {
                value = random.Next(0, 9);
                contra += value.ToString();
            }
            return contra;
        }
        public DataTable Datos(string CodUsuario)
        {
            var usuario = from user in dc.TUsuario
                          where user.Dni_Usuario == CodUsuario
                          select new {
                              user.Nombre,
                              user.Apellido_Paterno,
                              user.Apellido_Materno,
                              user.Dni_Usuario
                          };
            DataTable dt = ToDataTable(dc, usuario);
            return dt;
        }
    }
}
