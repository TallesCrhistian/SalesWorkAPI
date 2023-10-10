using AutoMapper;
using SalesWorkAPI.Entites;
using SalesWorkAPI.Shared.DTOs;
using SalesWorkAPI.Shared.ModelsView.Customer;

namespace SalesWorkAPI.Utils.MappingProfiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDTO>();
            CreateMap<CustomerDTO, Customer>();
            CreateMap<CustomerCreateViewModel, CustomerDTO>();
            CreateMap<CustomerUpdateViewModel, CustomerDTO>();
            CreateMap<CustomerListViewModel, CustomerDTO>();
            CreateMap<CustomerDTO, CustomerViewModel>();
        }
    }
}
