using Abp.Application.Services.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.ThongTinVaHanhXe.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.ThongTinVaHanhXes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Application.Controllers
{
    [Route("api/[controller]/[action]")]
    public class ThongTinVanHanhXeController : GWebsiteControllerBase
    {
        private readonly IThongTinVanHanhXeAppService thongTinVanHanhXeAppService;

        public ThongTinVanHanhXeController(IThongTinVanHanhXeAppService thongTinVanHanhXeAppService)
        {
            this.thongTinVanHanhXeAppService = thongTinVanHanhXeAppService;
        }

        [HttpGet]
        public PagedResultDto<ThongTinVanHanhXeDto> GetThongTinVanHanhXeByFilter(ThongTinVanHanhXeFilter thongTinVanHanhXeFilter)
        {
            return thongTinVanHanhXeAppService.GetThongTinVanHanhXes(thongTinVanHanhXeFilter);
        }

        [HttpGet]
        public ThongTinVanHanhXeInput GetThongTinVanHanhXeForEdit(int id)
        {
            return thongTinVanHanhXeAppService.GetThongTinVanHanhXeForEdit(id);
        }

        [HttpPost]
        public void CreateOrEditThongTinVanHanhXe([FromBody] ThongTinVanHanhXeInput input)
        {
            thongTinVanHanhXeAppService.CreateOrEditThongTinVanHanhXe(input);
        }

        [HttpDelete("{id}")]
        public void DeleteThongTinVanHanhXe(int id)
        {
            thongTinVanHanhXeAppService.DeleteThongTinVanHanhXe(id);
        }

        [HttpGet]
        public ThongTinVanHanhXeForViewDto GetThongTinVanhanhXeForView(int id)
        {
            return thongTinVanHanhXeAppService.GetThongTinVanHanhXeForView(id);
        }
    }
}
