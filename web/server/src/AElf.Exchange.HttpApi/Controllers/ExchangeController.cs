using AElf.Exchange.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AElf.Exchange.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ExchangeController : AbpController
    {
        protected ExchangeController()
        {
            LocalizationResource = typeof(ExchangeResource);
        }
    }
}