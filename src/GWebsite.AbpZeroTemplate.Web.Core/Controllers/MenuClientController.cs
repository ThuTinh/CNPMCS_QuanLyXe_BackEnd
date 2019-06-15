using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Notifications;
using GSoft.AbpZeroTemplate.Authorization.Users;
using GWebsite.AbpZeroTemplate.Application.Controllers.Notify;
using GWebsite.AbpZeroTemplate.Application.Share.MenuClients;
using GWebsite.AbpZeroTemplate.Application.Share.MenuClients.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Application.Controllers
{
    [Route("api/[controller]/[action]")]
    public class MenuClientController : GWebsiteControllerBase
    {
        private readonly INotificationPublisher _notificationPublisher;
        private readonly IRepository<User, long> userRepository;
        
        private readonly IMenuClientAppService _menuClientAppService;

        public MenuClientController(IMenuClientAppService menuClientAppService,
            IRepository<User, long> userRepository,
            INotificationPublisher notificationPublisher)
        {
            _menuClientAppService = menuClientAppService;
            _notificationPublisher = notificationPublisher;
            this.userRepository = userRepository;
        }

        [HttpGet]
        public  async Task<string> GetTest()
        {
            var users = await userRepository.GetAll().ToListAsync();
            await _notificationPublisher.PublishAsync(
                "Chào thu tình",
                new MessageNotificationData("Đây là nội dung của thông báo"),
                severity: NotificationSeverity.Success,
                userIds: users.Select(x => x.ToUserIdentifier()).ToArray()
                );

          
            return "Test";
            
        }
       

        [HttpGet]
        public async Task<ListResultDto<MenuClientDto>> GetMenuClients()
        {
            return await _menuClientAppService.GetMenuClientsAsync();
        }

        [HttpGet]
        public async Task<PagedResultDto<MenuClientListDto>> GetMenuClientsByFilter(string name, string sorting, int skipCount = 0, int maxResultCount = 1)
        {
            return await _menuClientAppService.GetMenuClientsAsync(new GetMenuClientInput() { Name = name, Sorting = sorting, SkipCount = skipCount, MaxResultCount = maxResultCount });
        }

        [HttpGet]
        public string DemoWebApi()
        {
            return "Abcdezz";
        }

        [HttpGet]
        public async Task<GetMenuClientOutput> GetMenuClientForEdit(int id)
        {
            return await _menuClientAppService.GetMenuClientForEditAsync(new NullableIdDto() { Id = id });
        }

        [HttpPost]
        public async Task<MenuClientDto> CreateMenuClient([FromBody] CreateMenuClientInput input)
        {
            return await _menuClientAppService.CreateMenuClientAsync(input);
        }

        [HttpPut]
        public async Task<MenuClientDto> UpdateMenuClient([FromBody] UpdateMenuClientInput input)
        {
            return await _menuClientAppService.UpdateMenuClientAsync(input);
        }

        [HttpDelete("{id}")]
        public async Task DeleteMenuClient(int id)
        {
            await _menuClientAppService.DeleteMenuClientAsync(new EntityDto<int>() { Id = id });
        }
    }
}
