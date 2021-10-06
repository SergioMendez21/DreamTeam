using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejercicio.Models;

namespace Ejercicio.Controllers
{
    public class ApiController : Controller
    {
        public string getDate()
        {
            return DateTime.Now.ToString();
        }
        public JsonResult getInfo()
        {
            return Json(new { a = 2, b=7 });
        }
        public JsonResult getPersona()
        {
            Persona resp = new Persona
            {
                id = 0,
                Nombre = "Sergio"
            };
            return Json(resp);
        }
        public JsonResult getList()
        {
            List<Persona> personas = new List<Persona>
            {
                new Persona {id=1, Nombre="Dario" },
                new Persona {id=2, Nombre="Jorge" },
                new Persona {id=3, Nombre = "Luis" },
                new Persona {id=4, Nombre = "Alejandro" }
            };

            return Json(personas);
        }
        public JsonResult getDetalle(int id)
        {
            List<Persona> personas = new List<Persona>
            {
                new Persona {id=1, Nombre="Dario" },
                new Persona {id=2, Nombre="Jorge" },
                new Persona {id=3, Nombre = "Luis" },
                new Persona {id=4, Nombre = "Alejandro" }
            };

            return Json(personas.Single(r=>r.id==id));
        }
        [HttpGet]
        public JsonResult Suma([FromBody]Suma s)
        {
            return Json(new { r =s.a+s.b});
        }
    }
}

