using GSoft.AbpZeroTemplate.Dto;
using GWebsite.AbpZeroTemplate.Core.Models;
using System;

namespace GWebsite.AbpZeroTemplate.Application.Share.Xes.Dto
{
    /// <summary>
    /// <model cref="Xe"></model>
    /// </summary>
    public class XeFilter : PagedAndSortedInputDto
    {
        public string Ten { get; set; }
    }
}