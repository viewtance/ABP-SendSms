using Abp.AspNetCore.Mvc.ViewComponents;

namespace Viewtance.ERP.Web.Views
{
    public abstract class ERPViewComponent : AbpViewComponent
    {
        protected ERPViewComponent()
        {
            LocalizationSourceName = ERPConsts.LocalizationSourceName;
        }
    }
}
