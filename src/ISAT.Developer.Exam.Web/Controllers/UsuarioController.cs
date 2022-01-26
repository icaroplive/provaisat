using AutoMapper;
using ISAT.Developer.Exam.Core.Entities.Models;
using ISAT.Developer.Exam.Core.Interfaces;
using ISAT.Developer.Exam.Core.Services;
using ISAT.Developer.Exam.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISAT.Developer.Exam.Web.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IRepository<Usuario> _repository;
        private readonly IMapper _mapper;

        public UsuarioController(IRepository<Usuario> repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public IActionResult Index()
        {
            var usuarios = _repository.GetAll();

            var model = _mapper.Map<List<UsuarioViewModel>>(usuarios);
            return View(model);
        }
        // Delete
        // GET: Usuarios/Delete/5
        public IActionResult Delete(long id)
        {
            var user = _repository.GetById(id);
            var model = _mapper.Map<UsuarioViewModel>(user);
            return View(model);
        }
        // POST: Usuarios/Delete/5
        [HttpPost]
        public ActionResult Delete(UsuarioViewModel user)
        {
            var model = _mapper.Map<Usuario>(user);
            try
            {
                _repository.Delete(user.Id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewData["Mensagem"] = "Erro: " + ex.ToString();
                return View(user);
            }
            return View(user);
        }

        // POST: Usuarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioViewModel user)
        {

            var model = _mapper.Map<Usuario>(user);

            _repository.Insert(model);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit(long id)
        {
            var user = _repository.GetById(id);
            var model = _mapper.Map<UsuarioViewModel>(user);
            return View(model);
        }

        // POST: Usuarios/Edit/5
        [HttpPost]
        public ActionResult Edit(UsuarioViewModel user)
        {
            var model = _mapper.Map<Usuario>(user);

            _repository.Update(model);
            return RedirectToAction(nameof(Index));
        }
    }
}
