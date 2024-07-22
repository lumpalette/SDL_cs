using System;

namespace SDL_cs;

/// <summary>
/// An enumeration of blend modes used in drawing operations.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BlendMode">documentation</see> for more details.
/// </remarks>
[Flags]
public enum SDL_BlendMode : uint
{
	/// <summary>
	/// No blending: <c>dstRGBA = srcRGBA</c>.
	/// </summary>
	None = 0x00000000u,

	/// <summary>
	/// Alpha blending: <c>dstRGB = (srcRGB * srcA) + (dstRGB * (1-srcA))</c>, <c>dstA = srcA + (dstA * (1-srcA))</c>.
	/// </summary>
	Blend = 0x00000001u,

	/// <summary>
	/// Pre-multiplied alpha blending: <c>dstRGBA = srcRGBA + (dstRGBA * (1-srcA))</c>.
	/// </summary>
	BlendPremultiplied = 0x00000010u,

	/// <summary>
	/// Additive blending: <c>dstRGB = (srcRGB * srcA) + dstRGB, dstA = dstA</c>.
	/// </summary>
	Add = 0x00000002u,

	/// <summary>
	/// Pre-multiplied additive blending: <c>dstRGB = srcRGB + dstRGB, dstA = dstA</c>.
	/// </summary>
	AddPremultiplied = 0x00000020u,

	/// <summary>
	/// Color modulate: <c>dstRGB = srcRGB * dstRGB, dstA = dstA</c>.
	/// </summary>
	Mod = 0x00000004u,

	/// <summary>
	/// Color multiply: <c>dstRGB = (srcRGB * dstRGB) + (dstRGB * (1-srcA)), dstA = dstA</c>
	/// </summary>
	Mul = 0x00000008u,

	/// <summary>
	/// Invalid blend mode.
	/// </summary>
	Invalid = 0x7FFFFFFFu
}