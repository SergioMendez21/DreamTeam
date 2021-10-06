using System;
using System.Collections.Generic;

#nullable disable

namespace Ejercicio.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            Registros = new HashSet<Registro>();
        }

        public long IdUsuario { get; set; }
        public string Usuario1 { get; set; }
        public string Contraseña { get; set; }

        public virtual ICollection<Registro> Registros { get; set; }
    }
}
