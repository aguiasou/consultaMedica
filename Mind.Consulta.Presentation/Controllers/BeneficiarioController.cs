using Mind.Consulta.Domain.IRepositories;
using Mind.Consulta.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mind.Consulta.Presentation.Controllers
{
    public class BeneficiarioController : Controller
    {
        private readonly IBeneficiarioRespository beneficiarioRepo;


        public BeneficiarioController(IBeneficiarioRespository beneficiarioRepo)
        {
            this.beneficiarioRepo = beneficiarioRepo;
        }


        // GET: Beneficiario
        //public async Task<ActionResult> Index()
        //{

        //}

        // GET: Beneficiario
        //public async Task<ActionResult> Edit(long id)
        //{

        //}

        //public ActionResult Insert()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public async Task<ActionResult> Save(BeneficiarioViewModel beneficiarioViewModel)
        //{

        //}
    }
}