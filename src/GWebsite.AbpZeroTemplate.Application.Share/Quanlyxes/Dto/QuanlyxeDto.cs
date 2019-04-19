
using Abp.Domain.Entities;
using GWebsite.AbpZeroTemplate.Core.Models;
//Đây là lớp mô tả các đối tượng của bảng trong view
namespace GWebsite.AbpZeroTemplate.Application.Share.Quanlyxes.Dto
{

    /// <summary>
    /// <model cref="Quanlyxe"></model>
    /// </summary>
    public class QuanlyxeDto : Entity<int>
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Info { get; set; }
    }
}