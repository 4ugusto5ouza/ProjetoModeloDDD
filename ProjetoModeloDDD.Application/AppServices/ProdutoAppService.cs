using ProjetoModeloDDD.Application.Interfaces;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application.AppServices
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _service;

        public ProdutoAppService(IProdutoService service)
            : base(service)
        {
            _service = service;
        }

        public IEnumerable<Produto> GetByDescricao(string descricao)
        {
            return _service.GetByDescricao(descricao);
        }
    }
}
