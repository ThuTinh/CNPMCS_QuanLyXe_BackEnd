using Abp.Application.Services.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.Xes.Dto;

namespace GWebsite.AbpZeroTemplate.Application.Share.Xes
{
    public interface IXeAppService
    {
        void CreateOrEditXe(XeInput xeInput);
        XeInput GetXeForEdit(int id);
        void DeleteXe(int id);
        PagedResultDto<XeDto> GetXes(XeFilter input);
        XeForViewDto GetXeForView(int id);
    }
}