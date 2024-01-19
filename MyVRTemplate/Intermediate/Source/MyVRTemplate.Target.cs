using UnrealBuildTool;

public class MyVRTemplateTarget : TargetRules
{
	public MyVRTemplateTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("MyVRTemplate");
	}
}
