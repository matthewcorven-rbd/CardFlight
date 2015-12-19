using System;
using ObjCRuntime;

[assembly: LinkWith ("libCardFlightAttacheLibrary.a", LinkTarget.ArmV7 | LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.Arm64, Frameworks = "ExternalAccessory", LinkerFlags = "-lstdc++ -lz", SmartLink = true, ForceLoad = true, IsCxx = true)]
