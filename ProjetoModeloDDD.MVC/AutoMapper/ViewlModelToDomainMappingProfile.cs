using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.AutoMapper
{
    public class ViewlModelToDomainMappingProfile : Profile
    {
        public ViewlModelToDomainMappingProfile()
        {

            // Add as many of these lines as you need to map your objects
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ProdutoViewModel, Produto>();
        }
    }
}
