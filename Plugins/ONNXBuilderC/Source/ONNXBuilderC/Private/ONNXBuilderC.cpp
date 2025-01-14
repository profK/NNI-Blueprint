// Copyright Epic Games, Inc. All Rights Reserved.

#include "ONNXBuilderC.h"

#define LOCTEXT_NAMESPACE "FONNXBuilderCModule"

void FONNXBuilderCModule::StartupModule()
{
	// This code will execute after your module is loaded into memory; the exact timing is specified in the .uplugin file per-module
}

void FONNXBuilderCModule::ShutdownModule()
{
	// This function may be called during shutdown to clean up your module.  For modules that support dynamic reloading,
	// we call this function before unloading the module.
}

OpaqueModel& FONNXBuilderCModule::MakeMLP(int input_layer,int hidden_layer,int hidden_layer_count,int output_layer,
					float bias)
{
	return MakeMLP(input_layer,hidden_layer,hidden_layer_count,output_layer,bias);
}

#undef LOCTEXT_NAMESPACE
	
IMPLEMENT_MODULE(FONNXBuilderCModule, ONNXBuilderC)