// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class URALROLEPLAY : ModuleRules
{
	public URALROLEPLAY(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"URALROLEPLAY",
			"URALROLEPLAY/Variant_Horror",
			"URALROLEPLAY/Variant_Horror/UI",
			"URALROLEPLAY/Variant_Shooter",
			"URALROLEPLAY/Variant_Shooter/AI",
			"URALROLEPLAY/Variant_Shooter/UI",
			"URALROLEPLAY/Variant_Shooter/Weapons"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
