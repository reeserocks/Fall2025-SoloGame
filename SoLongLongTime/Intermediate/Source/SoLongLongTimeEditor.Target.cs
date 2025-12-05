using UnrealBuildTool;

public class SoLongLongTimeEditorTarget : TargetRules
{
	public SoLongLongTimeEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("SoLongLongTime");
	}
}
