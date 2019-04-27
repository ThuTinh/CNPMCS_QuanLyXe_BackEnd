﻿using Abp.Application.Services.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.TaiSans;
using GWebsite.AbpZeroTemplate.Application.Share.TaiSans.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Application.Controllers
{
    [Route("api/[controller]/[action]")]
    public  class TaiSanController : GWebsiteControllerBase
    {
        private readonly ITaiSanAppService taiSanAppService;
        public TaiSanController(ITaiSanAppService taiSanAppService)
        {
            this.taiSanAppService = taiSanAppService;
        }
        [HttpGet]
        public PagedResultDto<TaiSanDto> GetTaiSanByFilter(TaiSanFilter filter)
        {
            return taiSanAppService.GetTaiSans(filter);
        }
        [HttpGet]
        public TaiSanInput GetTaiSanForEdit(int id)
        {
            return taiSanAppService.GetTaiSanForEdit(id);
        }

        [HttpGet]
        public TaiSanForViewDto GetTaiSanForView(int id)
        {
            return taiSanAppService.GetTaiSanForView(id);
        }
        [HttpPost]
        public void CreateOrEditTaiSan([FromBody]TaiSanInput input)
        {
            taiSanAppService.CreateOrEditTaiSan(input);
        }
        [HttpDelete("{id}")]
        public void DeleteTaiSan(int id)
        {
            taiSanAppService.DeleteTaiSan(id);
        }
    }
}
