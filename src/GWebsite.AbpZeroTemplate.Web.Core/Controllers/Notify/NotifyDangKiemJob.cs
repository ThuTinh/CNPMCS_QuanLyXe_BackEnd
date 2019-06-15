using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Notifications;
using GSoft.AbpZeroTemplate.Authorization.Users;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Application.Controllers.Notify
{
    public class NotifyDangKiemJob: IJob
    {
        public string soXe { private get; set; }


        public async Task Execute(IJobExecutionContext context)
        {
            JobDataMap dataMap = context.JobDetail.JobDataMap;
            string xe = dataMap.GetString("soXe");

            Console.WriteLine("Chay job");
            var _notificationPublisher = IocManager.Instance.IocContainer.Resolve<INotificationPublisher>();
            var userRepository = IocManager.Instance.IocContainer.Resolve<IRepository<User, long>>();
            var users = await userRepository.GetAllListAsync();
            await _notificationPublisher.PublishAsync(
                "Thông báo",
                new MessageNotificationData("Hôm nay là ngày đăng kiểm xe " + xe),
                severity: NotificationSeverity.Success,
                userIds: users.Select(x => x.ToUserIdentifier()).ToArray()
                );


            Console.WriteLine("Chay job xong");

        }
    }
}
