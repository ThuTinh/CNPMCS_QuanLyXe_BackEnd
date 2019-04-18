using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Application.Share.ThongTinVaHanhXe.Dto
{
  public  class ThongTinVanHanhXeInput : Entity<int>
    {
        public float SoKm { get; set; }
        public float XangTieuThu { get; set; }
        public string TrangThai { get; set; }
        public string GhiChu { get; set; }
        public string ThongTinXeId { get; set; }
    }
}
