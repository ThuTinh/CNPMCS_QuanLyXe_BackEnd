using AutoMapper;
using GWebsite.AbpZeroTemplate.Application.Share.QuanLyVanHanhs.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.ThongTinBaoDuongs.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.Customers.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.Xes.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.DemoModels.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.MenuClients.Dto;
using GWebsite.AbpZeroTemplate.Core.Models;

namespace GWebsite.AbpZeroTemplate.Applications
{
    internal static class CustomDtoMapper
    {
        public static void CreateMappings(IMapperConfigurationExpression configuration)
        {
            configuration.CreateMap<MenuClient, MenuClientDto>();
            configuration.CreateMap<MenuClient, MenuClientListDto>();
            configuration.CreateMap<CreateMenuClientInput, MenuClient>();
            configuration.CreateMap<UpdateMenuClientInput, MenuClient>();

            // DemoModel
            configuration.CreateMap<DemoModel, DemoModelDto>();
            configuration.CreateMap<DemoModelInput, DemoModel>();
            configuration.CreateMap<DemoModel, DemoModelInput>();
            configuration.CreateMap<DemoModel, DemoModelForViewDto>();

            // Customer
            configuration.CreateMap<Customer, CustomerDto>();
            configuration.CreateMap<CustomerInput, Customer>();
            configuration.CreateMap<Customer, CustomerInput>();
            configuration.CreateMap<Customer, CustomerForViewDto>();

           

            // Quan ly van hanh
            configuration.CreateMap<QuanLyVanHanh, QuanLyVanHanhDto>();
            configuration.CreateMap<QuanLyVanHanhInput, QuanLyVanHanh>();
            configuration.CreateMap<QuanLyVanHanh, QuanLyVanHanhInput>();
            configuration.CreateMap<QuanLyVanHanh, QuanLyVanHanhForViewDto>();    
            
            // Thong tin bao duong 
            configuration.CreateMap<ThongTinBaoDuong, ThongTinBaoDuongDto>();
            configuration.CreateMap<ThongTinBaoDuongInput, ThongTinBaoDuong>();
            configuration.CreateMap<ThongTinBaoDuong, ThongTinBaoDuongInput>();
            configuration.CreateMap<ThongTinBaoDuong, ThongTinBaoDuongForViewDto>();
        }
    }
}