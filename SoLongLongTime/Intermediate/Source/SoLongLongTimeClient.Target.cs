using UnrealBuildTool;

public class SoLongLongTimeClientTarget : TargetRules
{
	public SoLongLongTimeClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("SoLongLongTime");
	}
}
