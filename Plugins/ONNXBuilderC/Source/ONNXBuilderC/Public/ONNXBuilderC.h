// Copyright Epic Games, Inc. All Rights Reserved.

#pragma once

#include "CoreMinimal.h"
#include "Modules/ModuleManager.h"
#include "ONNXBuilder.h"

class FONNXBuilderCModule : public IModuleInterface
{
public:

	/** IModuleInterface implementation */
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;
	virtual OpaqueModel& MakeMLP(int input_layer,int hidden_layer,int hidden_layer_count,int output_layer,
					float bias);
};
