using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejercicio.Models;

namespace Ejercicio.Controllers
{
    public class TestController : Controller
    {
        List<Persona> personas = new List<Persona>
        {
            new Persona {id=1, Nombre="Dario" },
            new Persona {id=2, Nombre="Jorge" },
            new Persona {id=3, Nombre = "Luis" },
            new Persona {id=4, Nombre = "Alejandro" }
        };
        public IActionResult Index()
        {
            return View();
        }
        public string Saludo(string id)
        {
            return "Buenos dias " + id;
        }

        public string Suma(int a, int b)
        {
            return a + "+" + b + "=" + (a + b);
        }
        public IActionResult Repe(int n)
        {
            var modelo = new Ejercicio.Models.Repe();
            modelo.n = n;
            return View(modelo);
        }
    }
}
