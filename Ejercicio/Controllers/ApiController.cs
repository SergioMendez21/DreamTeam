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
        public IActionResult getTemperatura(string Usuario, string Contrasena)
        {
            using (var db = new SENSORDETEMPERATURAContext())
            {

                var user = db.Usuarios.Where(x => x.Usuario1 == Usuario && x.Contraseña == Contrasena).FirstOrDefault();
                if (user != null)
                {
                    Random r = new Random();
                    var token = Convert.ToString(r.Next(128, 255), 2);
                    int Tokendb = int.Parse(token);

                    //Genera un numero entre 10 y 100 (101 no se incluye)
                    return Json(new { respuestatoken = Tokendb });

                }
                else {
                    return Json("Autenticación invalida");
                }
            }
        }
    }
}

