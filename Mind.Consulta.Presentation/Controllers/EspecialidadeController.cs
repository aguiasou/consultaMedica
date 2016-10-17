using Mind.Consulta.Domain.IRepositories;
using Mind.Consulta.Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Mind.Consulta.Presentation.Controllers
{
    public class EspecialidadeController : Controller
    {
        private readonly IEspecialidadeRepository especialidadeRepo;


        public EspecialidadeController(IEspecialidadeRepository especialidadeRepo)
        {
            this.especialidadeRepo = especialidadeRepo;
        }


        // GET: Especialidade
        public async Task<ActionResult> Index()
        {
            var lista = (await this.especialidadeRepo.FindAll()).Select(e => new EspecialidadeViewModel(e)).ToList();
            return View(lista);
        }

        // GET: Especialidade
        public async Task<ActionResult> Edit(long id)
        {
            var especialidade = await this.especialidadeRepo.FindById(id);
            return View(new EspecialidadeViewModel(especialidade));
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Save(EspecialidadeViewModel especialidadeViewModel)
        {
            var especialidade = especialidadeViewModel.ConvertToEspecialidade();
            await this.especialidadeRepo.Save(especialidade);

            return RedirectToAction("Edit", new { id = especialidade.Id });
        }



    }
}