using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicaMedica.Controllers
{
    public class SecretariaController : Controller
    {
        // GET: Secretaria
        public ActionResult CrearPaciente()
        {
            return View();
        }
        public ActionResult ModificarPaciente()
        {
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult Paciente()
        {
            return View();
        }
    }
}