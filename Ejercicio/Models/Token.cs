using System;
using System.Collections.Generic;

#nullable disable

namespace Ejercicio.Models
{
    public partial class Token
    {
        public Token()
        {
            Registros = new HashSet<Registro>();
        }

        public long IdToken { get; set; }
        public long Token1 { get; set; }

        public virtual ICollection<Registro> Registros { get; set; }
    }
}
