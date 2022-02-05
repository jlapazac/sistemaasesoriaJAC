using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sistemaasesoriaJAC.Controllers
{
    public class AlumnosController : Controller
    {
        private SocratesWS.SocratesServiceClient proxy = new SocratesWS.SocratesServiceClient();
        // GET: Alumnos
        public ActionResult Index()
        {
            return View();
        }
    }
}