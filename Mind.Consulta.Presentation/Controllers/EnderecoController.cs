using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mind.Consulta.Presentation.Controllers
{
    public class EnderecoController : Controller
    {
        // GET: Endereco
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Upload()
        {

            var file = this.Request.Files[0].InputStream;



            return View();

        }
    }
}