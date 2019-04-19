//Đây là lớp mô tả đối tượng dùng để tìm kiếm.
//Ví dụ hiện tại hệ thống chỉ cần tìm kiếm theo name thì mô tả lớp như sau

using GSoft.AbpZeroTemplate.Dto;
using GWebsite.AbpZeroTemplate.Core.Models;

namespace GWebsite.AbpZeroTemplate.Application.Share.Quanlyxes.Dto
{
    /// <summary>
    /// <model cref="Quanlyxe"></model>
    /// </summary>
    public class QuanlyxeFilter : PagedAndSortedInputDto
    {
        public string Name { get; set; }
    }
}