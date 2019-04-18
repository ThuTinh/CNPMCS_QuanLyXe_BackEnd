using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using GWebsite.AbpZeroTemplate.Application;
using GWebsite.AbpZeroTemplate.Application.Share.ThongTinVaHanhXe.Dto;
using GWebsite.AbpZeroTemplate.Application.Share.ThongTinVaHanhXes;
using GWebsite.AbpZeroTemplate.Core.Authorization;
using GWebsite.AbpZeroTemplate.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using Abp.Linq.Extensions;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Web.Core.ThongTinVanHanhXes
{
    [AbpAuthorize(GWebsitePermissions.Pages_Administration_MenuClient)]
    public class ThongTinVanHanhXeAppService : GWebsiteAppServiceBase, IThongTinVanHanhXeAppService
    {
        private readonly IRepository<ThongTinVanHanhXe> thongTinVanHanhXeRepository;

        public ThongTinVanHanhXeAppService (IRepository<ThongTinVanHanhXe> thongTinVanHanhXeRepository)
        {
            this.thongTinVanHanhXeRepository = thongTinVanHanhXeRepository;
        }
        public void CreateOrEditThongTinVanHanhXe(ThongTinVanHanhXeInput thongTinVanHanhXeInput)
        {
            if (thongTinVanHanhXeInput.Id == 0)
            {
                Create(thongTinVanHanhXeInput);
            }
            else
                Update(thongTinVanHanhXeInput);
        }

        [AbpAuthorize(GWebsitePermissions.Pages_Administration_MenuClient_Edit)]
        private void Update(ThongTinVanHanhXeInput thongTinVanHanhXeInput)
        {
            var thongTinVanHanhXeEntity = thongTinVanHanhXeRepository.GetAll().Where(x => !x.IsDelete).SingleOrDefault(x => x.Id == thongTinVanHanhXeInput.Id);
            if (thongTinVanHanhXeEntity == null)
            {

            }
            ObjectMapper.Map(thongTinVanHanhXeInput, thongTinVanHanhXeEntity);
            SetAuditEdit(thongTinVanHanhXeEntity);
            CurrentUnitOfWork.SaveChanges();
        }

        [AbpAuthorize(GWebsitePermissions.Pages_Administration_MenuClient_Create)]
        private void Create(ThongTinVanHanhXeInput thongTinVanHanhXeInput)
        {
            var thongTinVanHanhXeEntity = ObjectMapper.Map<ThongTinVanHanhXe>(thongTinVanHanhXeInput);
            SetAuditInsert(thongTinVanHanhXeEntity);
            thongTinVanHanhXeRepository.Insert(thongTinVanHanhXeEntity);
            CurrentUnitOfWork.SaveChanges();
        }



        public void DeleteThongTinVanHanhXe(int id)
        {
            var thongTinVanHanhXeEntity = thongTinVanHanhXeRepository.GetAll().Where(x => !x.IsDelete).SingleOrDefault(x => x.Id == id);
            if(thongTinVanHanhXeEntity!=null)
            {
                thongTinVanHanhXeEntity.IsDelete = true;
                thongTinVanHanhXeRepository.Update(thongTinVanHanhXeEntity);
                CurrentUnitOfWork.SaveChanges();
            }
        }

        public ThongTinVanHanhXeInput GetThongTinVanHanhXeForEdit(int id)
        {
            var thongTinVanHanhXeEntity = thongTinVanHanhXeRepository.GetAll().Where(x => !x.IsDelete).SingleOrDefault(x => x.Id == id);
            if (thongTinVanHanhXeRepository == null)
                return null;
            else
            {
                return ObjectMapper.Map<ThongTinVanHanhXeInput>(thongTinVanHanhXeEntity);
            }
        }

        public PagedResultDto<ThongTinVanHanhXeDto> GetThongTinVanHanhXes(ThongTinVanHanhXeFilter input)
        {
            var query = thongTinVanHanhXeRepository.GetAll().Where(x => !x.IsDelete);

            //filler by value
            if (input.ThongTinXeId != null)
            {
                query = query.Where(x => x.ThongTinXeId.ToLower().Equals(input.ThongTinXeId));

            }
            var totalCount = query.Count();

            //sorting

            if (!string.IsNullOrWhiteSpace(input.Sorting))
            {
                query = query.OrderBy(input.Sorting);
            }

            //paging

            var items = query.PageBy(input).ToList();

            //resutl
            return new PagedResultDto<ThongTinVanHanhXeDto>(totalCount,
                items.Select(item => ObjectMapper.Map<ThongTinVanHanhXeDto>(item)).ToList());
        }

        public ThongTinVanHanhXeForViewDto GetThongTinVanHanhXeForView(int id)
        {
            var thongTinVanHanhXeEntity = thongTinVanHanhXeRepository.GetAll().Where(x => !x.IsDelete).SingleOrDefault(x => x.Id == id);
            if (thongTinVanHanhXeEntity == null)
                return null;
            return ObjectMapper.Map<ThongTinVanHanhXeForViewDto>(thongTinVanHanhXeEntity);
        }
    }
}
