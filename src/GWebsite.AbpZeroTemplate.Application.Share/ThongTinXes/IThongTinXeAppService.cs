using Abp.Application.Services.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.ThongTinXes.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Application.Share.ThongTinXes
{
  public  interface IThongTinXeAppService
    {
        void CreateOrEditThongTinXe(ThongTinXeInput thongTinXeInput);
        ThongTinXeInput GetThongTinXeForEdit(int id);
        void DeleteThongTinXe(int id);
        PagedResultDto<ThongTinXeDto> GetThongTinXes(ThongTinXeFilter input);
        ThongTinXeForViewDto GetThongTinXeForView(int id);
    }
}
