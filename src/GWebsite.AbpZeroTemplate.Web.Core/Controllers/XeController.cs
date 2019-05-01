using Abp.Application.Services.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.Xes;
using GWebsite.AbpZeroTemplate.Application.Share.Xes.Dto;
using Microsoft.AspNetCore.Mvc;

namespace GWebsite.AbpZeroTemplate.Application.Controllers
{
    [Route("api/[controller]/[action]")]
    public class XeController : GWebsiteControllerBase
    {
        private readonly IXeAppService xeAppService;

        public XeController(IXeAppService xeAppService)
        {
            this.xeAppService = xeAppService;
        }

        [HttpGet]
        public PagedResultDto<XeDto> GetXesByFilter(XeFilter xeFilter)
        {
            return xeAppService.GetXes(xeFilter);
        }

        [HttpGet]
        public XeInput GetXeForEdit(int id)
        {
            return xeAppService.GetXeForEdit(id);
        }

        [HttpPost]
        public void CreateOrEditXe([FromBody] XeInput input)
        {
            xeAppService.CreateOrEditXe(input);
        }

        [HttpDelete("{id}")]
        public void DeleteXe(int id)
        {
            xeAppService.DeleteXe(id);
        }

        [HttpGet]
        public XeForViewDto GetXeForView(int id)
        {
            return xeAppService.GetXeForView(id);
        }
    }
}
