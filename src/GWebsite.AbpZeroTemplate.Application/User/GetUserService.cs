using GWebsite.AbpZeroTemplate.Application;
using GWebsite.AbpZeroTemplate.Application.Share.ThongTinXes;
using GWebsite.AbpZeroTemplate.Application.Share.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Web.Core.User
{
    public class GetUserService : GWebsiteAppServiceBase, IGetUserService
    {
 
        public string GetUser()
        {

            var a = GetCurrentUser();
            string tem = a.UserName;
            return tem;

        }
    }
}
