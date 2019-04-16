using Abp.Application.Services.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.ThongTinXes;
using GWebsite.AbpZeroTemplate.Application.Share.ThongTinXes.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Application.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ThongTinXeController : GWebsiteControllerBase
    {
        private readonly IThongTinXeAppService thongTinXeAppService;
        public ThongTinXeController(IThongTinXeAppService thongTinXeAppService)
        {
            this.thongTinXeAppService = thongTinXeAppService;

        }
        [HttpGet]
        public PagedResultDto<ThongTinXeDto> GetThongTinXeByFilter(ThongTinXeFilter thongTinXeFilter)
        {
            return thongTinXeAppService.GetThongTinXes(thongTinXeFilter);
        }

        [HttpGet]
        public ThongTinXeInput GetThongTinXeForEdit(int id)
        {
            return thongTinXeAppService.GetThongTinXeForEdit(id);
        }
        [HttpPost]
        public void CreateOrEditThongTinXe([FromBody] ThongTinXeInput input)
        {
            thongTinXeAppService.CreateOrEditThongTinXe(input);
        }

        [HttpDelete("{id}")]
        public void DeleteThongTinXe(int id)
        {
            thongTinXeAppService.DeleteThongTinXe(id);
        }

        [HttpGet]
        public ThongTinXeForViewDto GetThongTinXeForView(int id)
        {
            return thongTinXeAppService.GetThongTinXeForView(id);
        }
    }
}
