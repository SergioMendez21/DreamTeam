using System;
using System.Collections.Generic;

#nullable disable

namespace Ejercicio.Models
{
    public partial class Registro
    {
        public long IdRegistro { get; set; }
        public long IdUsuario { get; set; }
        public long IdToken { get; set; }
        public double Temperatura { get; set; }

        public virtual Usuario IdUsuario1 { get; set; }
        public virtual Token IdUsuarioNavigation { get; set; }
    }
}
