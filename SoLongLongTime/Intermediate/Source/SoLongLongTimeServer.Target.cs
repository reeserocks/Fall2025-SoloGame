using UnrealBuildTool;

public class SoLongLongTimeServerTarget : TargetRules
{
	public SoLongLongTimeServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("SoLongLongTime");
	}
}
