using UnrealBuildTool;

public class PeopleWithGunsTarget : TargetRules
{
	public PeopleWithGunsTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("PeopleWithGuns");
	}
}
