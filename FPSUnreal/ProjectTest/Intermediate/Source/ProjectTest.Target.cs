using UnrealBuildTool;

public class ProjectTestTarget : TargetRules
{
	public ProjectTestTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("ProjectTest");
	}
}
