﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Controlador
{
    public class cHorario : cEntidad
    {
        public cHorario()
            : base("THorario")
        { }

        public override string[] NombresAtributos()
        {
            return new string[] { "CodHorario", "Horario" };

        }

    }
}