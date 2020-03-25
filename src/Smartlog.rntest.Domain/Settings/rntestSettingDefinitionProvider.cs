using Volo.Abp.Settings;

namespace Smartlog.rntest.Settings
{
    public class rntestSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(rntestSettings.MySetting1));
        }
    }
}
