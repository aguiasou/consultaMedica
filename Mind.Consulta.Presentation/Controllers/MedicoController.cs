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
    public class MedicoController : Controller
    {
        private readonly IEstadoRepository estadoRepo;
        private readonly ICidadeRespository cidadeRepo;
        private readonly IEspecialidadeRepository especialidadeRepo;
        private readonly IMedicoRepository medicoRepository;

        public MedicoController(IEstadoRepository estadoRepo, ICidadeRespository cidadeRepo, IEspecialidadeRepository especialidadeRepo, IMedicoRepository medicoRepository)
        {
            this.estadoRepo = estadoRepo;
            this.cidadeRepo = cidadeRepo;
            this.especialidadeRepo = especialidadeRepo;
            this.medicoRepository = medicoRepository;
        }

        // GET: Medico
        public ActionResult Index()
        {
            return View();
        }

        // GET: Medico/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public async Task< ActionResult> Insert()
        {
            var estados = await this.estadoRepo.FindAll();
            var especialidades =await this.especialidadeRepo.FindAll();
            var medicoViewModel = new MedicoViewModel(especialidades.Select(e=> new EspecialidadeViewModel(e)).ToList(), estados.Select(e=> new EstadoViewModel(e)).ToList());
            return View(medicoViewModel);
        }

        // GET: Medico/Create
        public ActionResult Edit()
        {
            return View();
        }

        // POST: Medico/Create
        [HttpPost]
        public ActionResult Save(MedicoViewModel viewModel)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Medico/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

       

    }
}
