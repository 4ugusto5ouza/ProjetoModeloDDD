using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoModeloDDD.Application.Interfaces;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.MVC.ViewModels;
using System.Collections.Generic;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class ClientesController : Controller

    {
        private readonly IClienteAppService _app;
        private readonly IMapper _mapper;

        public ClientesController(IMapper mapper, IClienteAppService app)
        {
            _mapper = mapper;
            _app = app;
        }

        // GET: ClientesController
        public ActionResult Index()
        {
            return View(_mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_app.GetAllAsNoTracking()));
        }

        // GET: ClientesController
        public ActionResult Especiais()
        {
            return View(_mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_app.GetClientesEspeciais()));
        }

        // GET: ClientesController/Details/5
        public ActionResult Details(int id)
        {
            return View(_mapper.Map<Cliente, ClienteViewModel>(_app.GetById(id)));
        }

        // GET: ClientesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel model)
        {
            if (ModelState.IsValid)
            {
                _app.Save(_mapper.Map<ClienteViewModel, Cliente>(model));
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: ClientesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_mapper.Map<Cliente, ClienteViewModel>(_app.GetById(id)));
        }

        // POST: ClientesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteViewModel model)
        {
            if (ModelState.IsValid)
            {
                _app.Update(_mapper.Map<ClienteViewModel, Cliente>(model));
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: ClientesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_mapper.Map<Cliente, ClienteViewModel>(_app.GetById(id)));
        }

        // POST: ClientesController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _app.Delete(_app.GetById(id));
            return RedirectToAction("Index");
        }
    }
}
