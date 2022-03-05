using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces;
using ProjetoModeloDDD.MVC.ViewModels;
using System.Collections.Generic;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class ClientesController : Controller

    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ClientesController(IMapper mapper, IClienteRepository clienteRepository)
        {
            _mapper = mapper;
            _clienteRepository = clienteRepository;
        }

        // GET: ClientesController
        public ActionResult Index()
        {
            return View(_mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteRepository.GetAllAsNoTracking()));
        }

        // GET: ClientesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
                _clienteRepository.Save(_mapper.Map<ClienteViewModel, Cliente>(model));
                return RedirectToAction("Index");
            }
            return View(model);
        }

        // GET: ClientesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClientesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClientesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClientesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
