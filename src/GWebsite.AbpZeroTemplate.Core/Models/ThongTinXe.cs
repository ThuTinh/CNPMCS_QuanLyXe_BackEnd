using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Core.Models
{
    public class ThongTinXe : FullAuditModel
    {
        public string soXe { get; set; }
        public string hangSanXuat { get; set; }
        public string loaiHopSo { get; set; }
        public float theTichDongCo { get; set; }
        public string model { get; set; }
        public string nuocSanXuat { get; set; }
        public string loaiNhienLieu { get; set; }
        public string soMay { get; set; }
        public string loaiXe { get; set; }
        public int namSanXuat { get; set; }
        public float dinhMucNhienLieu { get; set; }
        public string soSuon { get; set; }
    }
}
