using Abp.Domain.Entities;
using GWebsite.AbpZeroTemplate.Core.Models;

namespace GWebsite.AbpZeroTemplate.Application.Share.Xes.Dto
{
    /// <summary>
    /// <model cref="Xe"></model>
    /// </summary>
    public class XeInput : Entity<int>
    {
        public string Ten { get; set; }
        public string Hang { get; set; }
        public string Gia { get; set; }
    }
}