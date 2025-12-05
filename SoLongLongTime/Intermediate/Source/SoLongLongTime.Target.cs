using UnrealBuildTool;

public class SoLongLongTimeTarget : TargetRules
{
	public SoLongLongTimeTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("SoLongLongTime");
	}
}
