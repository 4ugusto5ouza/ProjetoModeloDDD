using ProjetoModeloDDD.Application.Interfaces;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.AppServices
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _service;

        public ClienteAppService(IClienteService service)
            : base(service)
        {
            _service = service;
        }

        public IEnumerable<Cliente> GetClientesEspeciais()
        {
            return _service.GetClientesEspeciais(_service.GetAll());
        }
    }
}
