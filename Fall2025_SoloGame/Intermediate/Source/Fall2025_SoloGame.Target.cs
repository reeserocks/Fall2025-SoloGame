using UnrealBuildTool;

public class Fall2025_SoloGameTarget : TargetRules
{
	public Fall2025_SoloGameTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("Fall2025_SoloGame");
	}
}
