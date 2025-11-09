using UnrealBuildTool;

public class Fall2025_SoloGameClientTarget : TargetRules
{
	public Fall2025_SoloGameClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("Fall2025_SoloGame");
	}
}
