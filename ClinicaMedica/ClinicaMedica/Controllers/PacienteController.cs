using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClinicaMedica.Controllers
{
    public class PacienteController : Controller
    {
       
        public ActionResult Paciente()
        {
            return View();
        }
        public ActionResult ModificarPaciente()
        {
            return View();
        }
        public ActionResult CrearPaciente()
        {
            return View();
        }
    }
}