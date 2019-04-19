using Abp.Application.Services.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.Quanlyxes;
using GWebsite.AbpZeroTemplate.Application.Share.Quanlyxes.Dto;
using Microsoft.AspNetCore.Mvc;


namespace GWebsite.AbpZeroTemplate.Application.Controllers
{
    [Route("api/[controller]/[action]")]
   public class QuanlyxeController : GWebsiteControllerBase
    {
        private readonly IQuanlyxeAppService quanlyxeAppService;

        public QuanlyxeController(IQuanlyxeAppService quanlyxeAppService)
        {
            this.quanlyxeAppService = quanlyxeAppService;
        }

        [HttpGet]
        public PagedResultDto<QuanlyxeDto> GetCustomersByFilter(QuanlyxeFilter quanlyxeFilter)
        {
            return quanlyxeAppService.GetQuanlyxes(quanlyxeFilter);
        }

        [HttpGet]
        public QuanlyxeInput GetQuanlyxeForEdit(int id)
        {
            return quanlyxeAppService.GetQuanlyxeForEdit(id);
        }

        [HttpPost]
        public void CreateOrEditQuanlyxe([FromBody] QuanlyxeInput input)
        {
            quanlyxeAppService.CreateOrEditQuanlyxe(input);
        }

        [HttpDelete("{id}")]
        public void DeleteQuanlyxe(int id)
        {
            quanlyxeAppService.DeleteQuanlyxe(id);
        }

        [HttpGet]
        public QuanlyxeForViewDto GetQuanlyxeForView(int id)
        {
            return quanlyxeAppService.GetQuanlyxeForView(id);
        }
    }
}
