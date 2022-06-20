using Volo.Abp.Settings;

namespace Amazing.Software.Settings;

public class SoftwareSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(SoftwareSettings.MySetting1));
    }
}
