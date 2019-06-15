using GWebsite.AbpZeroTemplate.Application.Share.User;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Application.Controllers
{
    [Route("api/[controller]/[action]")]
    public class UserSevicrController : GWebsiteControllerBase
    {
        private readonly IGetUserService service;
        public UserSevicrController(IGetUserService service)
        {
            this.service = service;
        }

        [HttpGet]
        public string GetUser()
        {
            return service.GetUser();
        }
    }
}
