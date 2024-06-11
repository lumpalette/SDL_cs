using System;

namespace SDL_cs;

/// <summary>
/// The normalized factor used to multiply pixel components.
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_BlendFactor">here</see>.
/// </remarks>
[Flags]
public enum SDL_BlendFactor
{
	/// <summary>
	/// <c>[0, 0, 0, 0]</c>
	/// </summary>
	Zero = 0x1,

	/// <summary>
	/// <c>[1, 1, 1, 1]</c>
	/// </summary>
	One = 0x2,

	/// <summary>
	/// <c>[srcR, srcG, srcB, srcA]</c>
	/// </summary>
	SrcColor = 0x3,

	/// <summary>
	/// <c>[1 - srcR, 1 - srcG, 1 - srcB, 1 - srcA]</c>
	/// </summary>
	OneMinusSrcColor = 0x4,

	/// <summary>
	/// <c>[srcA, srcA, srcA, srcA]</c>
	/// </summary>
	SrcAlpha = 0x5,

	/// <summary>
	/// <c>[1 - srcA, 1 - srcA, 1 - srcA, 1 - srcA]</c>
	/// </summary>
	OneMinusSrcAlpha = 0x6,

	/// <summary>
	/// <c>[dstR, dstG, dstB, dstA]</c>
	/// </summary>
	DstColor = 0x7,

	/// <summary>
	/// <c>[1 - dstR, 1 - dstG, 1 - dstB, 1 - dstA]</c>
	/// </summary>
	OneMinusDstColor = 0x8,

	/// <summary>
	/// <c>[dstA, dstA, dstA, dstA]</c>
	/// </summary>
	DstAlpha = 0x9,

	/// <summary>
	/// <c>[1 - dstA, 1 - dstA, 1 - dstA, 1 - dstA]</c>
	/// </summary>
	OneMinusDstAlpha = 0xA
}