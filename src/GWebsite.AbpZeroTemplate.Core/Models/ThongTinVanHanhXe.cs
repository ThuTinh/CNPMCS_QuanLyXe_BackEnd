using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Core.Models
{
    public class ThongTinVanHanhXe :FullAuditModel
    {
        
        public float SoKm { get; set; }
        public float XangTieuThu { get; set; }
        public string TrangThai { get; set; }
        public string GhiChu { get; set; }
        public string ThongTinXeId { get; set; }
        //public ThongTinXe ThongTinXe { get; set; }
        //public virtual ThongTinXe ThongTinXe { get; set; }
    }
}
