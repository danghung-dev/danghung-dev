using Smartlog.rntest.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Smartlog.rntest.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class rntestController : AbpController
    {
        protected rntestController()
        {
            LocalizationResource = typeof(rntestResource);
        }
    }
}