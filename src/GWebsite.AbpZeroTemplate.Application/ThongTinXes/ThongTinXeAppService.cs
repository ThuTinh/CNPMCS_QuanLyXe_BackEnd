using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using GWebsite.AbpZeroTemplate.Application;
using GWebsite.AbpZeroTemplate.Application.Share.ThongTinXes;
using GWebsite.AbpZeroTemplate.Application.Share.ThongTinXes.Dto;
using GWebsite.AbpZeroTemplate.Core.Authorization;
using GWebsite.AbpZeroTemplate.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using Abp.Linq.Extensions;
using System.Threading.Tasks;

namespace GWebsite.AbpZeroTemplate.Web.Core.ThongTinXes
{

    [AbpAuthorize(GWebsitePermissions.Pages_Administration_MenuClient)]
    public class ThongTinXeAppService : GWebsiteAppServiceBase, IThongTinXeAppService
    {

        private readonly IRepository<ThongTinXe> thongTinXeRepository;

        public ThongTinXeAppService(IRepository<ThongTinXe> thongTinXeRepository)
        {
            this.thongTinXeRepository = thongTinXeRepository;
        }


        #region Public Method

        public void CreateOrEditThongTinXe(ThongTinXeInput thongTinXeInput)
        {
            if (thongTinXeInput.Id == 0)
            {
                Create(thongTinXeInput);
            }
            else
            {
                Update(thongTinXeInput);
            }
        }

        public void DeleteThongTinXe(int id)
        {
            var thongTinXeEntity = thongTinXeRepository.GetAll().Where(x => !x.IsDelete).SingleOrDefault(x => x.Id == id);
            if (thongTinXeEntity != null)
            {
                thongTinXeEntity.IsDelete = true;
                thongTinXeRepository.Update(thongTinXeEntity);
                CurrentUnitOfWork.SaveChanges();
            }
        }

        public ThongTinXeInput GetThongTinXeForEdit(int id)
        {
            var thongTinXeEntity = thongTinXeRepository.GetAll().SingleOrDefault(x => x.Id == id);
            if (thongTinXeEntity == null)
                return null;
            return ObjectMapper.Map<ThongTinXeInput>(thongTinXeEntity);
        }

        public ThongTinXeForViewDto GetThongTinXeForView(int id)
        {
            var thongTinXeEntity = thongTinXeRepository.GetAll().Where(x => !x.IsDelete).SingleOrDefault(x => x.Id == id);
            if (thongTinXeEntity == null)
            {
                return null;
            }
            return ObjectMapper.Map<ThongTinXeForViewDto>(thongTinXeEntity);
        }

        public PagedResultDto<ThongTinXeDto> GetThongTinXes(ThongTinXeFilter input)
        {
            var query = thongTinXeRepository.GetAll().Where(x => !x.IsDelete);

            //filler by value
            if (input.ThongTinXeId != null)
            {
                query = query.Where(x => !x.ThongTinXeId.ToLower().Equals(input.ThongTinXeId));

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
            return new PagedResultDto<ThongTinXeDto>(totalCount,
                items.Select(item => ObjectMapper.Map<ThongTinXeDto>(item)).ToList());
        }
        #endregion
        #region Private Method
        [AbpAuthorize(GWebsitePermissions.Pages_Administration_MenuClient_Create)]
        private void Create(ThongTinXeInput thongTinXeInput)
        {
            var thongTinXeEntity = ObjectMapper.Map<ThongTinXe>(thongTinXeInput);
            SetAuditInsert(thongTinXeEntity);
            thongTinXeRepository.Insert(thongTinXeEntity);
            CurrentUnitOfWork.SaveChanges();

        }
        [AbpAuthorize(GWebsitePermissions.Pages_Administration_MenuClient_Edit)]
        private void Update(ThongTinXeInput thongTinXeInput)
        {
            var thongTinXeEntity = thongTinXeRepository.GetAll().Where(x => !x.IsDelete).SingleOrDefault(x => x.Id == thongTinXeInput.Id);
            if (thongTinXeEntity == null)
            {

            }
            ObjectMapper.Map(thongTinXeInput, thongTinXeEntity);
            SetAuditEdit(thongTinXeEntity);
            CurrentUnitOfWork.SaveChanges();

        }
        #endregion
    }
}
