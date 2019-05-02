using Abp.Application.Services.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.ThongTinVaHanhXe.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Application.Share.ThongTinVaHanhXes
{
   public interface IThongTinVanHanhXeAppService
    {
      
        void CreateOrEditThongTinVanHanhXe(ThongTinVanHanhXeInput thongTinVaHanhXeInput);
        ThongTinVanHanhXeInput GetThongTinVanHanhXeForEdit(int id);
        void DeleteThongTinVanHanhXe(int id);
        PagedResultDto<ThongTinVanHanhXeDto> GetThongTinVanHanhXes(ThongTinVanHanhXeFilter input);
        ThongTinVanHanhXeForViewDto GetThongTinVanHanhXeForView(int id);

    }
}
