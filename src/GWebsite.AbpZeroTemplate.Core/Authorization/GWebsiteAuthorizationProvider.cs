﻿using Abp.Authorization;
using Abp.Configuration.Startup;
using Abp.Localization;
using GSoft.AbpZeroTemplate;

namespace GWebsite.AbpZeroTemplate.Core.Authorization
{
    /// <summary>
    /// Application's authorization provider.
    /// Defines permissions for the application.
    /// See <see cref="AppPermissions"/> for all permission names.
    /// </summary>
    public class GWebsiteAuthorizationProvider : AuthorizationProvider
    {
        private readonly bool _isMultiTenancyEnabled;

        public GWebsiteAuthorizationProvider(bool isMultiTenancyEnabled)
        {
            _isMultiTenancyEnabled = isMultiTenancyEnabled;
        }

        public GWebsiteAuthorizationProvider(IMultiTenancyConfig multiTenancyConfig)
        {
            _isMultiTenancyEnabled = multiTenancyConfig.IsEnabled;
        }

        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            //COMMON PERMISSIONS (FOR BOTH OF TENANTS AND HOST)

            var pages = context.GetPermissionOrNull(GWebsitePermissions.Pages) ?? context.CreatePermission(GWebsitePermissions.Pages, L("Pages"));
            var gwebsite = pages.CreateChildPermission(GWebsitePermissions.Pages_Administration_GWebsite, L("GWebsite"));

            var menuClient = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_MenuClient, L("MenuClient"));
            menuClient.CreateChildPermission(GWebsitePermissions.Pages_Administration_MenuClient_Create, L("CreatingNewMenuClient"));
            menuClient.CreateChildPermission(GWebsitePermissions.Pages_Administration_MenuClient_Edit, L("EditingMenuClient"));
            menuClient.CreateChildPermission(GWebsitePermissions.Pages_Administration_MenuClient_Delete, L("DeletingMenuClient"));

            var demoModel = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_DemoModel, L("DemoModel"));
            demoModel.CreateChildPermission(GWebsitePermissions.Pages_Administration_DemoModel_Create, L("CreatingNewDemoModel"));
            demoModel.CreateChildPermission(GWebsitePermissions.Pages_Administration_DemoModel_Edit, L("EditingDemoModel"));
            demoModel.CreateChildPermission(GWebsitePermissions.Pages_Administration_DemoModel_Delete, L("DeletingDemoModel"));

            var customer = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_Customer, L("Customer"));
            customer.CreateChildPermission(GWebsitePermissions.Pages_Administration_Customer_Create, L("CreatingNewCustomer"));
            customer.CreateChildPermission(GWebsitePermissions.Pages_Administration_Customer_Edit, L("EditingCustomer"));
            customer.CreateChildPermission(GWebsitePermissions.Pages_Administration_Customer_Delete, L("DeletingCustomer"));

            var model = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_Model, L("Model"));
             model.CreateChildPermission(GWebsitePermissions.Pages_Administration_Model_Create, L("CreatingModel"));
            model.CreateChildPermission(GWebsitePermissions.Pages_Administration_Model_Edit, L("EditingModel"));
            model.CreateChildPermission(GWebsitePermissions.Pages_Administration_Model_Delete, L("DeletingModel"));

            var nhacungcap = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_NhaCungCap, L("NhaCungCap"));
            nhacungcap.CreateChildPermission(GWebsitePermissions.Pages_Administration_NhaCungCap_Create, L("CreatingNhaCungCap"));
            nhacungcap.CreateChildPermission(GWebsitePermissions.Pages_Administration_NhaCungCap_Edit, L("EditingNhaCungCap"));
            nhacungcap.CreateChildPermission(GWebsitePermissions.Pages_Administration_NhaCungCap_Delete, L("DeletingNhaCungCap"));

            var taisan = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_TaiSan, L("TaiSan"));
            taisan.CreateChildPermission(GWebsitePermissions.Pages_Administration_TaiSan_Create, L("CreatingTaiSan"));
            taisan.CreateChildPermission(GWebsitePermissions.Pages_Administration_TaiSan_Edit, L("EditingTaiSan"));
            taisan.CreateChildPermission(GWebsitePermissions.Pages_Administration_TaiSan_Delete, L("DeletingTaiSan"));

            var thongtinxe = gwebsite.CreateChildPermission(GWebsitePermissions.Pages_Administration_ThongTinXe, L("ThongTinXe"));
            thongtinxe.CreateChildPermission(GWebsitePermissions.Pages_Administration_ThongTinXe_Create, L("CreatingThongTinXe"));
            thongtinxe.CreateChildPermission(GWebsitePermissions.Pages_Administration_ThongTinXe_Edit, L("EditingThongTinXe"));
            thongtinxe.CreateChildPermission(GWebsitePermissions.Pages_Administration_ThongTinXe_Delete, L("DeletingThongTinXe"));

        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, AbpZeroTemplateConsts.LocalizationSourceName);
        }
    }
}
