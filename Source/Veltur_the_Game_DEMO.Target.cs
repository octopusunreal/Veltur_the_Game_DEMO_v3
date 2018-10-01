// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Veltur_the_Game_DEMOTarget : TargetRules
{
	public Veltur_the_Game_DEMOTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "Veltur_the_Game_DEMO" } );
	}
}
