using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// SDL_blendmode.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_blendmode.h.
namespace SDL3;

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

/// <summary>
/// The blend operation used when combining source and destination pixel components.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BlendOperation">documentation</see> for more details.
/// </remarks>
[Flags]
public enum SDL_BlendOperation
{
	/// <summary>
	/// <c>dst + src</c>: supported by all renderers.
	/// </summary>
	Add = 0x1,

	/// <summary>
	/// <c>src - dst</c>: supported by D3D9, D3D11, OpenGL, OpenGLES.
	/// </summary>
	Subtract = 0x2,

	/// <summary>
	/// <c>dst - src</c>: supported by D3D9, D3D11, OpenGL, OpenGLES.
	/// </summary>
	RevSubtract = 0x3,

	/// <summary>
	/// <c>min(dst, src)</c>: supported by D3D9, D3D11.
	/// </summary>
	Minimum = 0x4,

	/// <summary>
	/// <c>max(dst, src)</c>: supported by D3D9, D3D11.
	/// </summary>
	Maximum = 0x5,
}

/// <summary>
/// The normalized factor used to multiply pixel components.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_BlendFactor">documentation</see> for more details.
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
	/// <c>[1-srcR, 1-srcG, 1-srcB, 1-srcA]</c>
	/// </summary>
	OneMinusSrcColor = 0x4,

	/// <summary>
	/// <c>[srcA, srcA, srcA, srcA]</c>
	/// </summary>
	SrcAlpha = 0x5,

	/// <summary>
	/// <c>[1-srcA, 1-srcA, 1-srcA, 1-srcA]</c>
	/// </summary>
	OneMinusSrcAlpha = 0x6,

	/// <summary>
	/// <c>[dstR, dstG, dstB, dstA]</c>
	/// </summary>
	DstColor = 0x7,

	/// <summary>
	/// <c>[1-dstR, 1-dstG, 1-dstB, 1-dstA]</c>
	/// </summary>
	OneMinusDstColor = 0x8,

	/// <summary>
	/// <c>[dstA, dstA, dstA, dstA]</c>
	/// </summary>
	DstAlpha = 0x9,

	/// <summary>
	/// <c>[1-dstA, 1-dstA, 1-dstA, 1-dstA]</c>
	/// </summary>
	OneMinusDstAlpha = 0xA
}

unsafe partial class SDL
{
	/// <summary>
	/// Compose a custom blend mode for renderers.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_ComposeCustomBlendMode">documentation</see> for more details.
	/// </remarks>
	/// <param name="srcColorFactor">The <see cref="SDL_BlendFactor"/> applied to the red, green, and blue components of the source pixels.</param>
	/// <param name="dstColorFactor">The <see cref="SDL_BlendFactor"/> applied to the red, green, and blue components of the destination pixels.</param>
	/// <param name="colorOperation">The <see cref="SDL_BlendOperation"/> used to combine the red, green, and blue components of the source and destination pixels.</param>
	/// <param name="srcAlphaFactor">The <see cref="SDL_BlendFactor"/> applied to alpha component of the source pixels.</param>
	/// <param name="dstAlphaFactor">The <see cref="SDL_BlendFactor"/> applied to the alpha component of the destination pixels.</param>
	/// <param name="alphaOperation">The <see cref="SDL_BlendOperation"/> used to combine the alpha component of the source and destination pixels.</param>
	/// <returns>An <see cref="SDL_BlendMode"/> that represents the chosen factors and operations.</returns>
	[LibraryImport(LibraryName, EntryPoint = "SDL_ComposeCustomBlendMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	public static partial SDL_BlendMode ComposeCustomBlendMode(SDL_BlendFactor srcColorFactor, SDL_BlendFactor dstColorFactor, SDL_BlendOperation colorOperation, SDL_BlendFactor srcAlphaFactor, SDL_BlendFactor dstAlphaFactor, SDL_BlendOperation alphaOperation);
}