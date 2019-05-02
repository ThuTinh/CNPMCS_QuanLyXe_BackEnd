using AutoMapper;
using GWebsite.AbpZeroTemplate.Application.Share.Customers.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.DemoModels.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.MenuClients.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.PhiDuongBos;

using GWebsite.AbpZeroTemplate.Application.Share.Models.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.NhaCungCap.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.TaiSans.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.ThongTinXes.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.ThongTinSuaChuas.DTO;
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
            // PhiDuongBo
            configuration.CreateMap<PhiDuongBo, PhiDuongBoDTO>();
            configuration.CreateMap<PhiDuongBoInput, PhiDuongBo>();
            configuration.CreateMap<PhiDuongBo, PhiDuongBoInput>();
            configuration.CreateMap<PhiDuongBo, PhiDuongBoForViewDTO>();
            // Model
            configuration.CreateMap<Model , ModelDto>();
            configuration.CreateMap<ModelInput, Model>();
            configuration.CreateMap<Model, ModelInput>();
            configuration.CreateMap<Model, ModelForViewDto>();

            // NhaCungCap
            configuration.CreateMap<NhaCungCap, NhaCungCapDto>();
            configuration.CreateMap<NhaCungCapInput, NhaCungCap>();
            configuration.CreateMap<NhaCungCap, NhaCungCapInput>();
            configuration.CreateMap<NhaCungCap, NhaCungCapForViewDto>();

            //taisan
            configuration.CreateMap<TaiSan, TaiSanDto>();
            configuration.CreateMap<TaiSanInput, TaiSan>();
            configuration.CreateMap<TaiSan, TaiSanInput>();
            configuration.CreateMap<TaiSan, TaiSanForViewDto>();

            //thongtinxe
            configuration.CreateMap<ThongTinXe, ThongTinXeDto>();
            configuration.CreateMap<ThongTinXeInput, ThongTinXe>();
            configuration.CreateMap<ThongTinXe, ThongTinXeInput>();
            configuration.CreateMap<ThongTinXe, ThongTinXeForViewDto>();

            //thongtinSuchua
            configuration.CreateMap<ThongTinSuaChua, ThongTinSuaChuaDTO>();
            configuration.CreateMap<ThongTinSuaChuaInput, ThongTinSuaChua>();
            configuration.CreateMap<ThongTinSuaChua, ThongTinSuaChuaInput>();
            configuration.CreateMap<ThongTinSuaChua, ThongTinSuaChuaForViewDTO>();


        }
    }
}