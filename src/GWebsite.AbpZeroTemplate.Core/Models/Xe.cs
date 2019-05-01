using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Core.Models
{
    public class Xe : FullAuditModel
    {
        public string Ten { get; set; }
        public string Hang { get; set; }
        public string Gia { get; set; }
    }
}
