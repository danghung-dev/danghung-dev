using System;
using System.Collections.Generic;
using System.Text;
using Smartlog.rntest.Localization;
using Volo.Abp.Application.Services;

namespace Smartlog.rntest
{
    /* Inherit your application services from this class.
     */
    public abstract class rntestAppService : ApplicationService
    {
        protected rntestAppService()
        {
            LocalizationResource = typeof(rntestResource);
        }
    }
}
