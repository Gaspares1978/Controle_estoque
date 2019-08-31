using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Controle_estoque.web.Controllers
{
    public class GraficoController : Controller
    {
        [Authorize]
        public ActionResult Perdames()
        {
            return View();
        }
        [Authorize]
        public ActionResult EntradaSaidaMes()
        {
            return View();
        }
    }
}
