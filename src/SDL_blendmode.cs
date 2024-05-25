using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SDL3;

// SDL_blendmode.h located at https://github.com/libsdl-org/SDL/blob/main/include/SDL3/SDL_blendmode.h.
unsafe partial class SDL
{
	/// <summary>
	/// An enumeration of blend modes used in drawing operations.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_BlendMode">here</see>.
	/// </remarks>
	[Flags]
	public enum BlendMode
	{
		/// <summary>
		/// No blending:
		/// <code>
		/// dstRGBA = srcRGBA.
		/// </code>
		/// </summary>
		None = 0x00000000,

		/// <summary>
		/// Alpha blending:
		/// <code>
		/// dstRGB = (srcRGB * srcA) + (dstRGB * (1 - srcA)).
		/// dstA = srcA + (dstA * (1 - srcA))
		/// </code>
		/// </summary>
		Blend = 0x00000001,

		/// <summary>
		/// Additive blending:
		/// <code>
		/// dstRGB = (srcRGB * srcA) + dstRGB
		/// dstA = dstA
		/// </code>
		/// </summary>
		Add = 0x00000002,

		/// <summary>
		/// Color modulate:
		/// <code>
		/// dstRGB = srcRGB * dstRGB
		/// dstA = dstA
		/// </code>
		/// </summary>
		Mod = 0x00000004,

		/// <summary>
		/// Color multiply:
		/// <code>
		/// dstRGB = (srcRGB * dstRGB) + (dstRGB * (1 - srcA))
		/// dstA = dstA
		/// </code>
		/// </summary>
		Mul = 0x00000008,

		/// <summary>
		/// Invalid blend mode.
		/// </summary>
		Invalid = 0x7FFFFFFF
	}

	/// <summary>
	/// The blend operation used when combining source and destination pixel components.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_BlendOperation">here</see>.
	/// </remarks>
	[Flags]
	public enum BlendOperation
	{
		/// <summary>
		/// <c>dst + src</c>. Supported by all renderers.
		/// </summary>
		Add = 0x1,

		/// <summary>
		/// <c>src - dst</c>. Supported by D3D9, D3D11, OpenGL, OpenGLES.
		/// </summary>
		Subtract = 0x2,

		/// <summary>
		/// <c>dst - src</c>. Supported by D3D9, D3D11, OpenGL, OpenGLES.
		/// </summary>
		RevSubtract = 0x3,

		/// <summary>
		/// <c>min(dst, src)</c>. Supported by D3D9, D3D11.
		/// </summary>
		Minimum = 0x4,

		/// <summary>
		/// <c>max(dst, src)</c>. Supported by D3D9, D3D11.
		/// </summary>
		Maximum = 0x5,
	}

	/// <summary>
	/// The normalized factor used to multiply pixel components.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_BlendFactor">here</see>.
	/// </remarks>
	[Flags]
	public enum BlendFactor
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

	/// <summary>
	/// Compose a custom blend mode for renderers.
	/// </summary>
	/// <remarks>
	/// The official documentation for this symbol can be found <see href="https://wiki.libsdl.org/SDL3/SDL_ComposeCustomBlendMode">here</see>.
	/// </remarks>
	/// <param name="srcColorFactor"> The <see cref="BlendFactor"/> applied to the red, green, and blue components of the source pixels. </param>
	/// <param name="dstColorFactor"> The <see cref="BlendFactor"/> applied to the red, green, and blue components of the destination pixels. </param>
	/// <param name="colorOperation"> The <see cref="BlendOperation"/> used to combine the red, green, and blue components of the source and destination pixels. </param>
	/// <param name="srcAlphaFactor"> The <see cref="BlendFactor"/> applied to alpha component of the source pixels. </param>
	/// <param name="dstAlphaFactor"> The <see cref="BlendFactor"/> applied to the alpha component of the destination pixels. </param>
	/// <param name="alphaOperation"> The <see cref="BlendOperation"/> used to combine the alpha component of the source and destination pixels. </param>
	/// <returns> A <see cref="BlendMode"/> that represents the chosen factors and operations. </returns>
	public static BlendMode ComposeCustomBlendMode(BlendFactor srcColorFactor, BlendFactor dstColorFactor, BlendOperation colorOperation, BlendFactor srcAlphaFactor, BlendFactor dstAlphaFactor, BlendOperation alphaOperation)
	{
		return _PInvokeComposeCustomBlendMode(srcColorFactor, dstColorFactor, colorOperation, srcAlphaFactor, BlendFactor.DstAlpha, alphaOperation);
	}

	[LibraryImport(LibraryName, EntryPoint = "SDL_ComposeCustomBlendMode")]
	[UnmanagedCallConv(CallConvs = [typeof(CallConvCdecl)])]
	private static partial BlendMode _PInvokeComposeCustomBlendMode(BlendFactor srcColorFactor, BlendFactor dstColorFactor, BlendOperation colorOperation, BlendFactor srcAlphaFactor, BlendFactor dstAlphaFactor, BlendOperation alphaOperation);
}