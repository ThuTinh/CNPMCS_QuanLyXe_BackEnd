//Đây là lớp mô tả đối tượng của trang thêm/ chỉnh sửa xe
using Abp.Domain.Entities;
using GWebsite.AbpZeroTemplate.Core.Models;

namespace GWebsite.AbpZeroTemplate.Application.Share.Quanlyxes.Dto
{
    /// <summary>
    /// <model cref="Quanlyxe"></model>
    /// </summary>
    public class QuanlyxeInput : Entity<int>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Info { get; set; }
    }
}