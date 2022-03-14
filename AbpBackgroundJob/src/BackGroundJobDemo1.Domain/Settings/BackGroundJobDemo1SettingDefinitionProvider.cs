using Volo.Abp.Settings;

namespace BackGroundJobDemo1.Settings;

public class BackGroundJobDemo1SettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(BackGroundJobDemo1Settings.MySetting1));
    }
}
