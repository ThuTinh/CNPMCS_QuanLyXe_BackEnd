using Abp.Application.Services.Dto;
using Abp.Dependency;
using GWebsite.AbpZeroTemplate.Application.Controllers.Notify;
using GWebsite.AbpZeroTemplate.Application.Share.ThongTinXes;
using GWebsite.AbpZeroTemplate.Application.Share.ThongTinXes.Dto;
using GWebsite.AbpZeroTemplate.Core.Helper;
using Microsoft.AspNetCore.Mvc;
using Quartz;
using Quartz.Impl;
using Quartz.Spi;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Application.Controllers
{
    [Route("api/[controller]/[action]")]
  public  class ThongTinXeController : GWebsiteControllerBase
    {
        private readonly IThongTinXeAppService thongTinXeAppService;
        IScheduler sched;

        public ThongTinXeController(IThongTinXeAppService thongTinXeAppService)
        {
            this.thongTinXeAppService = thongTinXeAppService;
        }


        [HttpGet]
        public async Task AddbaoHiemJob(string soXe, int year, int month, int day)
        {
            QuartzJonFactory factory = (QuartzJonFactory)IocManager.Instance.IocContainer.Resolve<IJobFactory>();
            sched = await factory.GetScheduler();
            if (!sched.IsStarted)
            {
                await sched.Start();
              
            }
            DateTime dateScheduler = new DateTime(year, month, day, 15, 46, 0);
            ITrigger trigger = TriggerBuilder.Create()
             .WithIdentity("myTrigger", "BaoHiemXe"+soXe )
             .StartAt(dateScheduler)
               .WithCalendarIntervalSchedule(x => x.WithIntervalInDays(1))

             .Build();

            var job = await sched.GetJobDetail(new JobKey("myJob", "BaoHiemXe"+soXe));

            if (job == null)
            {
                var jobBuilder = JobBuilder.Create<NotifyBaoHiemJob>()
                                .WithIdentity("myJob", "BaoHiemXe" +soXe)
                                .UsingJobData("soXe", soXe);

                job = jobBuilder.Build();
              
                Console.Write("Chạy vô null");

                await sched.ScheduleJob(job, trigger);
            }
            else
            {
              
                Console.Write("Chạy vô khác null");
                await sched.UnscheduleJob(trigger.Key);
                await sched.ScheduleJob(job, trigger);
            }

        }

        [HttpGet]
        public async Task AddBaoDuongJob(string soXe, int year, int month, int day)
        {
            QuartzJonFactory factory = (QuartzJonFactory)IocManager.Instance.IocContainer.Resolve<IJobFactory>();
            sched = await factory.GetScheduler();
            if (!sched.IsStarted)
            {
                await sched.Start();
        
            }

            //    DateTime dateScheduler = new DateTime(2019, 6, 12, 9, 0, 0);

            //ITrigger trigger = TriggerBuilder.Create()
            //  .WithIdentity("myTrigger", "group1")
            //  .StartAt(dateScheduler)
            //  .WithCalendarIntervalSchedule(x => x.WithIntervalInDays(1))
            //  .Build();
            DateTime dateScheduler = new DateTime(year, month, day, 12, 49, 0);
            ITrigger trigger = TriggerBuilder.Create()
               .WithIdentity("myTrigger", "BaoDuongXe" + soXe)
               .StartAt(dateScheduler)
               .WithCalendarIntervalSchedule(x => x.WithIntervalInDays(1))
               .Build();

            var job = await sched.GetJobDetail(new JobKey("myJob", "BaoDuongXe" + soXe));

            if (job == null)
            {
                var jobBuilder = JobBuilder.Create<NotifyBaoDuongJob>()
                                .WithIdentity("myJob", "BaoDuongXe" + soXe)
                                .UsingJobData("soXe", soXe);

                job = jobBuilder.Build();
                Console.Write("Chạy vô null");

                await sched.ScheduleJob(job, trigger);
            }
            else
            {
                Console.Write("Chạy vô khác null");
                await sched.UnscheduleJob(trigger.Key);
                await sched.ScheduleJob(job, trigger);
            }

        }

        [HttpGet]
        public async Task AddDangKiemJob(string soXe, int year, int month, int day)
        {
            QuartzJonFactory factory = (QuartzJonFactory)IocManager.Instance.IocContainer.Resolve<IJobFactory>();
            sched = await factory.GetScheduler();
            if (!sched.IsStarted)
            {
                await sched.Start();

            }
            DateTime dateScheduler = new DateTime(year, month, day, 14, 30, 0);
            ITrigger trigger = TriggerBuilder.Create()
               .WithIdentity("myTrigger", "DangKiemXe" + soXe)
              .StartAt(dateScheduler)
               .WithCalendarIntervalSchedule(x => x.WithIntervalInDays(1))
               .Build();

            var job = await sched.GetJobDetail(new JobKey("myJob", "DangKiemXe" + soXe));

            if (job == null)
            {
                var jobBuilder = JobBuilder.Create<NotifyDangKiemJob>()
                                .WithIdentity("myJob", "DangKiemXe" + soXe)
                                .UsingJobData("soXe", soXe);

                job = jobBuilder.Build();
                Console.Write("Chạy vô null");

                await sched.ScheduleJob(job, trigger);
            }
            else
            {
                Console.Write("Chạy vô khác null");
                await sched.UnscheduleJob(trigger.Key);
                await sched.ScheduleJob(job, trigger);
            }

        }

        [HttpGet]
        public async Task AddPhiDuongBoJob(string soXe, int year, int month, int day)
        {
            QuartzJonFactory factory = (QuartzJonFactory)IocManager.Instance.IocContainer.Resolve<IJobFactory>();
            sched = await factory.GetScheduler();
            if (!sched.IsStarted)
            {
                await sched.Start();

            }
            DateTime dateScheduler = new DateTime(year, month, day, 14, 30, 0);
            ITrigger trigger = TriggerBuilder.Create()
               .WithIdentity("myTrigger", "PhiDuongBoXe" + soXe)
               .StartAt(dateScheduler)
               .WithCalendarIntervalSchedule(x => x.WithIntervalInDays(1))
               .Build();

            var job = await sched.GetJobDetail(new JobKey("myJob", "PhiDuongBoXe" + soXe));

            if (job == null)
            {
                var jobBuilder = JobBuilder.Create<NotifyPhiDuongBoJob>()
                                .WithIdentity("myJob", "PhiDuongBoXe" + soXe)
                                .UsingJobData("soXe", soXe);

                job = jobBuilder.Build();
                Console.Write("Chạy vô null");

                await sched.ScheduleJob(job, trigger);
            }
            else
            {
                Console.Write("Chạy vô khác null");
                await sched.UnscheduleJob(trigger.Key);
                await sched.ScheduleJob(job, trigger);
            }

        }

        [HttpGet]
        public async Task StartSched()
        {
            try
            {
                QuartzJonFactory factory = (QuartzJonFactory)IocManager.Instance.IocContainer.Resolve<IJobFactory>();
               sched = await factory.GetScheduler();
                Console.Write("trước khi  lịch trình");
                if (!sched.IsStarted)
                {
                    Console.Write("Bắt đầu Tạo xong lịch trình");
                    await sched.Start();
                    Console.Write("Tạo xong lịch trình");
                }

                //// construct a scheduler factory
                //ISchedulerFactory schedFact = new StdSchedulerFactory();

                //// get a scheduler
                //IScheduler sched = await schedFact.GetScheduler();
                //await sched.Start();

                // define the job and tie it to our HelloJob class
                //IJobDetail job = JobBuilder.Create<NotifyBaoDuongJob>()
                //     .WithIdentity("myJob", "group1")
                //     .Build();

                //var nextTime = DateTime.Now.AddMinutes(1);

                // Trigger the job to run now, and then every 40 seconds

                //    DateTime dateScheduler = new DateTime(2019, 6, 12, 9, 0, 0);

                //ITrigger trigger = TriggerBuilder.Create()
                //  .WithIdentity("myTrigger", "group1")
                //  .StartAt(dateScheduler)
                //  .WithCalendarIntervalSchedule(x => x.WithIntervalInDays(1))
                //  .Build();


                //này chạy nè

                // ITrigger trigger = TriggerBuilder.Create()
                // .WithIdentity("myTrigger", "group1")
                // .StartNow()
                //.WithSimpleSchedule(x => x

                //  .WithIntervalInSeconds(10)

                //   .RepeatForever())

                // .Build();

                // var job = await sched.GetJobDetail(new JobKey("myJob", "group1"));

                // if (job == null)
                // {
                //     var jobBuilder = JobBuilder.Create<NotifyBaoDuongJob>()
                //                     .WithIdentity("myJob", "group1")
                //                     .UsingJobData("soXe", "12345");


                //     job = jobBuilder.Build();
                //     Console.Write("Chạy vô null");

                //     await sched.ScheduleJob(job, trigger);
                // }
                // else
                // {
                //     Console.Write("Chạy vô khác null");
                //     await sched.UnscheduleJob(trigger.Key);
                //     await sched.ScheduleJob(job, trigger);
                // }

             //   await AddbaoHiemJob();

            }
            catch(Exception e)
            {
                throw e;
            }

        }

        [HttpGet]
        public PagedResultDto<ThongTinXeDto> GetThongTinXeByFilter(ThongTinXeFilter filter)
        {
            return thongTinXeAppService.GetThongTinXes(filter);
        }
        [HttpGet]
        public    ThongTinXeForViewDto GetThongTinXeForView(string soXe)
        {
            return thongTinXeAppService.GetThongTinXeForView(soXe);
        }
        [HttpGet]
        public ThongTinXeInput GetThongTinSeForEdit(string soXe)
        {
            return thongTinXeAppService.GetThongTinXeForEdit(soXe);
        }
        [HttpPost]
        public   void CreateOrEditThongTinXe([FromBody]ThongTinXeInput input)
        {
             thongTinXeAppService.CreateOrEditThongTinXe(input);
        }

        [HttpDelete("{soxe}")]
        public void DeleteThongTinXe(string soxe)
        {
            thongTinXeAppService.DeleteThongTinXe(soxe);
        }

    }
}
