using System;

namespace Sabresaurus.SabreCSG.Importers.UnrealGold;

[Flags]
public enum T3dPolygonFlags
{
	Invisible = 1,
	Masked = 2,
	Translucent = 4,
	Environment = 0x10,
	Modulated = 0x40,
	FakeBackdrop = 0x80,
	TwoSided = 0x100,
	UPan = 0x200,
	VPan = 0x400,
	NoSmooth = 0x800,
	SpecialPoly = 0x1000,
	SmallWavy = 0x2000,
	ForceViewZone = 0x4000,
	LowShadowDetail = 0x8000,
	AlphaBlend = 0x20000,
	DirtyShadows = 0x40000,
	BrightCorners = 0x80000,
	SpecialLit = 0x100000,
	NoBoundsReject = 0x200000,
	Unlit = 0x400000,
	HighShadowDetail = 0x800000,
	Portal = 0x4000000,
	Mirror = 0x8000000
}
