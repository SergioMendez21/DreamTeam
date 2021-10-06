using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejercicio.Models;

namespace Ejercicio.Controllers
{
    public class ListController : Controller
    {
        List<Persona> personas = new List<Persona>
        {
            new Persona {id=1, Nombre="Dario" },
            new Persona {id=2, Nombre="Jorge" },
            new Persona {id=3, Nombre = "Luis" },
            new Persona {id=4, Nombre = "Alejandro" }
        };
        public IActionResult Persona(int id, string Nombre)
        {
            return View();
        }
    }
}
