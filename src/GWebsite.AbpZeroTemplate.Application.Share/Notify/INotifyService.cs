using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Application.Share.Notify
{
    public interface INotifyService
    {
        List<NotifyDto> GetNotifies();
    }
}
