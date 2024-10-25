using System;

namespace SDL3;

/// <summary>
/// Possible values to be set for the <see cref="SDL_GLAttr.ContextProfileMask"/> attribute.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GLProfile">documentation</see> for more details.
/// </remarks>
[Flags]
public enum SDL_GLProfile : uint
{
	/// <summary>
	/// OpenGL Core Profile context.
	/// </summary>
	ContextProfileCore = 0x0001,

	/// <summary>
	/// OpenGL Compatibility Profile context.
	/// </summary>
	ContextProfileCompatibility = 0x0002,

	/// <summary>
	/// GLX_CONTEXT_ES2_PROFILE_BIT_EXT.
	/// </summary>
	ContextProfileES = 0x0004
}