using UnrealBuildTool;

public class IGPTarget : TargetRules
{
	public IGPTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("IGP");
	}
}
