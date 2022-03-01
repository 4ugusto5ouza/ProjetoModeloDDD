using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Produto, ProdutoViewModel>();
        }
    }
}
