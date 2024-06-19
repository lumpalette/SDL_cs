using System;

namespace SDL_cs;

/// <summary>
/// The blend operation used when combining source and destination pixel components.
/// </summary>
/// <remarks>
/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_BlendOperation">here</see> for more details.
/// </remarks>
[Flags]
public enum SDL_BlendOperation
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