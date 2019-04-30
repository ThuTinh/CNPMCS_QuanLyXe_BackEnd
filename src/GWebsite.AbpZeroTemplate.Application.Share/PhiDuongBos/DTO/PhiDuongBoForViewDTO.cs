using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GWebsite.AbpZeroTemplate.Core.Models;

namespace GWebsite.AbpZeroTemplate.Application.Share.PhiDuongBos
{
    public class PhiDuongBoForViewDTO
    {
        string soXe { get; set; }
        string ngayCapNhat { get; set; }
        string ngayDongPhi { get; set; }
        string ngayHetHanDongPhi { get; set; }
        string thoiGianSuDung { get; set; }
        string soTienThanhToan { get; set; }
        string congTyThuPhi { get; set; }
        string loaiPhi { get; set; }
        string ghiChu { get; set; }
    }
}
