using UnrealBuildTool;

public class Fall2025_SoloGameServerTarget : TargetRules
{
	public Fall2025_SoloGameServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("Fall2025_SoloGame");
	}
}
