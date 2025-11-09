using UnrealBuildTool;

public class Fall2025_SoloGameEditorTarget : TargetRules
{
	public Fall2025_SoloGameEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("Fall2025_SoloGame");
	}
}
