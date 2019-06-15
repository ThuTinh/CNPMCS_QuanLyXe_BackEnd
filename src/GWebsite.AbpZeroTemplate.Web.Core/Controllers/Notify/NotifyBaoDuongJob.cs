using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Notifications;
using GSoft.AbpZeroTemplate.Authorization.Users;
using GSoft.AbpZeroTemplate.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Application.Controllers.Notify
{
    class NotifyBaoDuongJob : IJob
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
                new MessageNotificationData("Hôm nay là ngày bảo dưỡng của xe  " + xe),
                severity: NotificationSeverity.Success,
                userIds: users.Select(x => x.ToUserIdentifier()).ToArray()
                );


            Console.WriteLine("Chay job xong");

        }
        //public async Task<string> GetTest()
        //{

        //    return "Test";
        //}
    }

    //public class JobScheduler

    //{

    //    IJobDetail job;
    //    ITrigger trigger;
    //    IScheduler Scheduler;

    //    public async Task StartAsync()
    //    {

    //        NameValueCollection props = new NameValueCollection
    //            {
    //                { "quartz.serializer.type", "binary" }
    //            };
    //        StdSchedulerFactory factory = new StdSchedulerFactory(props);

    //        IScheduler scheduler = await factory.GetScheduler();

    //        await Scheduler.Start();

    //        job = JobBuilder.Create<NotifyBaoDuongJob>().Build();

    //        trigger = TriggerBuilder.Create()
    //           .WithIdentity("trigger1", "group1")
    //        .StartNow()
    //        .WithSimpleSchedule(x => x
    //            .WithIntervalInSeconds(30)
    //            .RepeatForever())
    //        .Build();
    //        await Scheduler.ScheduleJob(job, trigger);


    //    }
    //}
}
