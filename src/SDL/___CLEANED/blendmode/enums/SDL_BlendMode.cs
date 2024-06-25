using System;

namespace SDL_cs;

/// <summary>
/// An enumeration of blend modes used in drawing operations.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BlendMode">documentation</see> for more details.
/// </remarks>
/// <seealso cref="SDL.ComposeCustomBlendMode(SDL_BlendFactor, SDL_BlendFactor, SDL_BlendOperation, SDL_BlendFactor, SDL_BlendFactor, SDL_BlendOperation)"/>
[Flags]
public enum SDL_BlendMode : uint
{
	/// <summary>
	/// No blending:
	/// <code>
	/// dstRGBA = srcRGBA.
	/// </code>
	/// </summary>
	None = 0x00000000u,

	/// <summary>
	/// Alpha blending:
	/// <code>
	/// dstRGB = (srcRGB * srcA) + (dstRGB * (1 - srcA)).
	/// dstA = srcA + (dstA * (1 - srcA))
	/// </code>
	/// </summary>
	Blend = 0x00000001u,

	/// <summary>
	/// Additive blending:
	/// <code>
	/// dstRGB = (srcRGB * srcA) + dstRGB
	/// dstA = dstA
	/// </code>
	/// </summary>
	Add = 0x00000002u,

	/// <summary>
	/// Color modulate:
	/// <code>
	/// dstRGB = srcRGB * dstRGB
	/// dstA = dstA
	/// </code>
	/// </summary>
	Mod = 0x00000004u,

	/// <summary>
	/// Color multiply:
	/// <code>
	/// dstRGB = (srcRGB * dstRGB) + (dstRGB * (1 - srcA))
	/// dstA = dstA
	/// </code>
	/// </summary>
	Mul = 0x00000008u,

	/// <summary>
	/// Invalid blend mode.
	/// </summary>
	Invalid = 0x7FFFFFFFu
}