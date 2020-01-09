using System;
using System.Collections.Generic;
using System.Text;
using AElf.Exchange.Localization;
using Volo.Abp.Application.Services;

namespace AElf.Exchange
{
    /* Inherit your application services from this class.
     */
    public abstract class ExchangeAppService : ApplicationService
    {
        protected ExchangeAppService()
        {
            LocalizationResource = typeof(ExchangeResource);
        }
    }
}
