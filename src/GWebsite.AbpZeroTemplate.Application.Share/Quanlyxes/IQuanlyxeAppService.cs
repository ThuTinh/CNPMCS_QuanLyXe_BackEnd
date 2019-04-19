using Abp.Application.Services.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.Quanlyxes.Dto;



namespace GWebsite.AbpZeroTemplate.Application.Share.Quanlyxes
{
    public interface IQuanlyxeAppService
    {
        void CreateOrEditQuanlyxe(QuanlyxeInput quanlyxeInput);
        QuanlyxeInput GetQuanlyxeForEdit(int id);
        void DeleteQuanlyxe(int id);
        PagedResultDto<QuanlyxeDto> GetQuanlyxes(QuanlyxeFilter input);
        QuanlyxeForViewDto GetQuanlyxeForView(int id);
    }
}