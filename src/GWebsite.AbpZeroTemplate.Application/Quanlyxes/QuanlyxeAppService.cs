using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using GWebsite.AbpZeroTemplate.Application;
using GWebsite.AbpZeroTemplate.Application.Share.Quanlyxes;
using GWebsite.AbpZeroTemplate.Application.Share.Quanlyxes.Dto;
using GWebsite.AbpZeroTemplate.Core.Authorization;
using GWebsite.AbpZeroTemplate.Core.Models;
using System.Linq;
using System.Linq.Dynamic.Core;


namespace GWebsite.AbpZeroTemplate.Web.Core.Quanlyxes
{
    [AbpAuthorize(GWebsitePermissions.Pages_Administration_MenuClient)]
    public class QuanlyxeAppService : GWebsiteAppServiceBase, IQuanlyxeAppService// tự tạo sauawr lỗi
    {
        private readonly IRepository<Quanlyxe> quanlyxeRepository;

        public QuanlyxeAppService(IRepository<Quanlyxe> quanlyxeRepository)
        {
            this.quanlyxeRepository = quanlyxeRepository;
        }

        #region Public Method

        public void CreateOrEditQuanlyxe(QuanlyxeInput quanlyxeInput)
        {
            if (quanlyxeInput.Id == 0)
            {
                Create(quanlyxeInput);
            }
            else
            {
                Update(quanlyxeInput);
            }
        }

      

        public void DeleteQuanlyxe(int id)
        {
            var quanlyxeEntity = quanlyxeRepository.GetAll().Where(x => !x.IsDelete).SingleOrDefault(x => x.Id == id);
            if (quanlyxeEntity != null)
            {
                quanlyxeEntity.IsDelete = true;
                quanlyxeRepository.Update(quanlyxeEntity);
                CurrentUnitOfWork.SaveChanges();
            }
        }

        public QuanlyxeInput GetQuanlyxeForEdit(int id)
        {
            var quanlyxeEntity = quanlyxeRepository.GetAll().Where(x => !x.IsDelete).SingleOrDefault(x => x.Id == id);
            if (quanlyxeEntity == null)
            {
                return null;
            }
            return ObjectMapper.Map<QuanlyxeInput>(quanlyxeEntity);
        }

        public QuanlyxeForViewDto GetQuanlyxeForView(int id)
        {
            var quanlyxeEntity = quanlyxeRepository.GetAll().Where(x => !x.IsDelete).SingleOrDefault(x => x.Id == id);
            if (quanlyxeEntity == null)
            {
                return null;
            }
            return ObjectMapper.Map<QuanlyxeForViewDto>(quanlyxeEntity);
        }

        public PagedResultDto<QuanlyxeDto> GetQuanlyxes(QuanlyxeFilter input)
        {
            var query = quanlyxeRepository.GetAll().Where(x => !x.IsDelete);

            // filter by value
            if (input.Name != null)
            {
                query = query.Where(x => x.Name.ToLower().Equals(input.Name));
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
            return new PagedResultDto<QuanlyxeDto>(
                totalCount,
                items.Select(item => ObjectMapper.Map<QuanlyxeDto>(item)).ToList());
        }

        #endregion

        #region Private Method

        [AbpAuthorize(GWebsitePermissions.Pages_Administration_MenuClient_Create)]
        private void Create(QuanlyxeInput quanlyxeInput)
        {
            var quanlyxeEntity = ObjectMapper.Map<Quanlyxe>(quanlyxeInput);
            SetAuditInsert(quanlyxeEntity);
            quanlyxeRepository.Insert(quanlyxeEntity);
            CurrentUnitOfWork.SaveChanges();
        }

        [AbpAuthorize(GWebsitePermissions.Pages_Administration_MenuClient_Edit)]
        private void Update(QuanlyxeInput quanlyxeInput)
        {
            var quanlyxeEntity = quanlyxeRepository.GetAll().Where(x => !x.IsDelete).SingleOrDefault(x => x.Id == quanlyxeInput.Id);
            if (quanlyxeEntity == null)
            {
            }
            ObjectMapper.Map(quanlyxeInput, quanlyxeEntity);
            SetAuditEdit(quanlyxeEntity);
            quanlyxeRepository.Update(quanlyxeEntity);
            CurrentUnitOfWork.SaveChanges();
        }

        #endregion
    }
}
