using AutoMapper;
using GWebsite.AbpZeroTemplate.Application.Share.Customers.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.DemoModels.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.MenuClients.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.ThongTinBaoHiems.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.ThongTinDangKiems.Dto;
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
            // thông tin đăng kiểm
            configuration.CreateMap<ThongTinDangKiem, ThongTinDangKiemDto>();
            configuration.CreateMap<ThongTinDangKiemInput, ThongTinDangKiem>();
            configuration.CreateMap<ThongTinDangKiem, ThongTinDangKiemInput>();
            configuration.CreateMap<ThongTinDangKiem, ThongTinDangKiemForViewDto>();
            // thông tin bảo hiểm
            configuration.CreateMap<ThongTinBaoHiem, ThongTinBaoHiemDto>();
            configuration.CreateMap<ThongTinBaoHiemInput, ThongTinBaoHiem>();
            configuration.CreateMap<ThongTinBaoHiem, ThongTinBaoHiemInput>();
            configuration.CreateMap<ThongTinBaoHiem, ThongTinBaoHiemForViewDto>();
        }
    }
}