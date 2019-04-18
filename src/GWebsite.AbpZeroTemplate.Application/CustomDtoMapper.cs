using AutoMapper;
using GWebsite.AbpZeroTemplate.Application.Share.Customers.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.DemoModels.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.MenuClients.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.ThongTinVaHanhXe.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.ThongTinXes.Dto;
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

            configuration.CreateMap<ThongTinXe, ThongTinXeDto>();
            configuration.CreateMap<ThongTinXeInput, ThongTinXe>();
            configuration.CreateMap<ThongTinXe, ThongTinXeInput>();
            configuration.CreateMap<ThongTinXe, ThongTinXeForViewDto>();

            configuration.CreateMap<ThongTinVanHanhXe, ThongTinVanHanhXeDto>();
            configuration.CreateMap<ThongTinVanHanhXeInput, ThongTinVanHanhXe>();
            configuration.CreateMap<ThongTinVanHanhXe, ThongTinVanHanhXeInput>();
            configuration.CreateMap<ThongTinVanHanhXe, ThongTinVanHanhXeForViewDto>();

        }
    }
}