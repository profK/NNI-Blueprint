// Copyright Epic Games, Inc. All Rights Reserved.

using System.IO;
using System.Reflection;
using UnrealBuildTool;

public class ONNXBuilderC : ModuleRules
{
	public ONNXBuilderC(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicIncludePaths.AddRange(
			new string[] {
				Path.Combine(ModuleDirectory,"ThirdParty","include")
			}
			);
				
		
	
		PublicAdditionalLibraries.AddRange(
			new string[]
			{
				Path.Combine(ModuleDirectory,"ThirdParty","lib","ONNXBuilder.lib"),
				Path.Combine(ModuleDirectory,"ThirdParty","lib","libprotobuf.lib"),
				Path.Combine(ModuleDirectory,"ThirdParty","lib","libprotobuf-lite.lib"),
				Path.Combine(ModuleDirectory,"ThirdParty","lib","libprotoc.lib"),
				Path.Combine(ModuleDirectory,"ThirdParty","lib","zlib.lib")
			}
			);	
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
				// ... add other public dependencies that you statically link with here ...
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
				"CoreUObject",
				"Engine",
				"Slate",
				"SlateCore",
				// ... add private dependencies that you statically link with here ...	
			}
			);
		
		
		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);
	}
}
