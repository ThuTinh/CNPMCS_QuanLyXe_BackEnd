using GSoft.AbpZeroTemplate.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Application.Share.ThongTinXes.Dto
{
    public class ThongTinXeFilter : PagedAndSortedInputDto
    {
        public string ThongTinXeId { get; set; }
    }
}
