using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using GWebsite.AbpZeroTemplate.Application;
using GWebsite.AbpZeroTemplate.Application.Share.Xes;
using GWebsite.AbpZeroTemplate.Application.Share.Xes.Dto;
using GWebsite.AbpZeroTemplate.Core.Authorization;
using GWebsite.AbpZeroTemplate.Core.Models;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace GWebsite.AbpZeroTemplate.Web.Core.Xes
{
    [AbpAuthorize(GWebsitePermissions.Pages_Administration_MenuClient)]
    public class XeAppService : GWebsiteAppServiceBase, IXeAppService
    {
        private readonly IRepository<Xe> xeRepository;

        public XeAppService(IRepository<Xe> xeRepository)
        {
            this.xeRepository = xeRepository;
        }

        #region Public Method

        public void CreateOrEditXe(XeInput xeInput)
        {
            if (xeInput.Id == 0)
            {
                Create(xeInput);
            }
            else
            {
                Update(xeInput);
            }
        }

        public void DeleteXe(int id)
        {
            var xeEntity = xeRepository.GetAll().Where(x => !x.IsDelete).SingleOrDefault(x => x.Id == id);
            if (xeEntity != null)
            {
                xeEntity.IsDelete = true;
                xeRepository.Update(xeEntity);
                CurrentUnitOfWork.SaveChanges();
            }
        }

        public XeInput GetXeForEdit(int id)
        {
            var xeEntity = xeRepository.GetAll().Where(x => !x.IsDelete).SingleOrDefault(x => x.Id == id);
            if (xeEntity == null)
            {
                return null;
            }
            return ObjectMapper.Map<XeInput>(xeEntity);
        }

        public XeForViewDto GetXeForView(int id)
        {
            var xeEntity = xeRepository.GetAll().Where(x => !x.IsDelete).SingleOrDefault(x => x.Id == id);
            if (xeEntity == null)
            {
                return null;
            }
            return ObjectMapper.Map<XeForViewDto>(xeEntity);
        }

        public PagedResultDto<XeDto> GetXes(XeFilter input)
        {
            var query = xeRepository.GetAll().Where(x => !x.IsDelete);

            // filter by value
            if (input.Ten != null)
            {
                query = query.Where(x => x.Ten.ToLower().Equals(input.Ten));
            }

            var totalCount = query.Count();

            // sorting
            if (!string.IsNullOrWhiteSpace(input.Sorting))
            {
                query = query.OrderBy(input.Sorting);
            }

            // paging
            var items = query.PageBy(input).ToList();

            // result
            return new PagedResultDto<XeDto>(
                totalCount,
                items.Select(item => ObjectMapper.Map<XeDto>(item)).ToList());
        }

        #endregion

        #region Private Method

        [AbpAuthorize(GWebsitePermissions.Pages_Administration_MenuClient_Create)]
        private void Create(XeInput xeInput)
        {
            var xeEntity = ObjectMapper.Map<Xe>(xeInput);
            SetAuditInsert(xeEntity);
            xeRepository.Insert(xeEntity);
            CurrentUnitOfWork.SaveChanges();
        }

        [AbpAuthorize(GWebsitePermissions.Pages_Administration_MenuClient_Edit)]
        private void Update(XeInput xeInput)
        {
            var xeEntity = xeRepository.GetAll().Where(x => !x.IsDelete).SingleOrDefault(x => x.Id == xeInput.Id);
            if (xeEntity == null)
            {
            }
            ObjectMapper.Map(xeInput, xeEntity);
            SetAuditEdit(xeEntity);
            xeRepository.Update(xeEntity);
            CurrentUnitOfWork.SaveChanges();
        }

        #endregion
    }
}
