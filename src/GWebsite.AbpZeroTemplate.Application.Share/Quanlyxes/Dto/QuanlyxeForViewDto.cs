//Đây là lớp mô tả đối tượng của trang xem quản lý xe
using GWebsite.AbpZeroTemplate.Core.Models;

namespace GWebsite.AbpZeroTemplate.Application.Share.Quanlyxes.Dto
{
    /// <summary>
    /// <model cref="Quanlyxe"></model>
    /// </summary>
    public class QuanlyxeForViewDto
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Info { get; set; }
    }
}