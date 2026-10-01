// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class Gameplay : ModuleRules
{
	public Gameplay(ReadOnlyTargetRules Target) : base(Target)
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
			"Gameplay",
			"Gameplay/Variant_Platforming",
			"Gameplay/Variant_Platforming/Animation",
			"Gameplay/Variant_Combat",
			"Gameplay/Variant_Combat/AI",
			"Gameplay/Variant_Combat/Animation",
			"Gameplay/Variant_Combat/Gameplay",
			"Gameplay/Variant_Combat/Interfaces",
			"Gameplay/Variant_Combat/UI",
			"Gameplay/Variant_SideScrolling",
			"Gameplay/Variant_SideScrolling/AI",
			"Gameplay/Variant_SideScrolling/Gameplay",
			"Gameplay/Variant_SideScrolling/Interfaces",
			"Gameplay/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
