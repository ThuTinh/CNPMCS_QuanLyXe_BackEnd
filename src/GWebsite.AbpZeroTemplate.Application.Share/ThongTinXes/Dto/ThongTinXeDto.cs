using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Application.Share.ThongTinXes.Dto
{
    public class ThongTinXeDto : EntityDto<int>
    {
        public string ThongTinXeId { get; set; }
        public string HangSanXuat { get; set; }
        public string TheTichDongCo { get; set; }
        public string NuocSanXuat { get; set; }
        public string LoaiNhienLieu { get; set; }
        public string LoaiXe { get; set; }
        public int NamSanXuat { get; set; }
    }
}
