using GWebsite.AbpZeroTemplate.Application;
using GWebsite.AbpZeroTemplate.Application.Share.Notify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Web.Core.Notify
{
    public class NotifyService : GWebsiteAppServiceBase, INotifyService
    {
        public List<NotifyDto> GetNotifies()
        {
            var ls = new List<NotifyDto>();
            return ls;

        }
    }
}
