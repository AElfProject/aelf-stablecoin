using Volo.Abp.Settings;

namespace AElf.Exchange.Settings
{
    public class ExchangeSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(ExchangeSettings.MySetting1));
        }
    }
}
