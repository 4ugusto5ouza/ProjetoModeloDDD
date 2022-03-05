using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _repository;

        public ProdutoService(IProdutoRepository repository)
            :base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<Produto> GetByDescricao(string descricao)
        {
           return _repository.GetByDescricao(descricao);
        }
    }
}
