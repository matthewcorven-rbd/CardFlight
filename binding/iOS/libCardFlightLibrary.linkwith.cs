using System;
using ObjCRuntime;

[assembly: LinkWith ("libCardFlightLibrary.a", 
	LinkTarget.ArmV7 | LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.Arm64 | LinkTarget.ArmV7 | LinkTarget.ArmV7s, 
	Frameworks = "AVFoundation AudioToolbox MediaPlayer MessageUI CoreGraphics ExternalAccessory Security QuartzCore",
	LinkerFlags = "-lstdc++.6.0.9",
	SmartLink = true, 
	ForceLoad = false)]
