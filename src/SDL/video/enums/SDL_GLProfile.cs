using System;

namespace SDL_cs;

/// <summary>
/// Possible values to be set for the <see cref="FIXME:SDL_GL_CONTEXT_PROFILE_MASK"/> attribute.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GLprofile">documentation</see> for more details.
/// </remarks>
[Flags]
public enum SDL_GLProfile
{
	Core = 0x0001,
	Compatibility = 0x0002,
	ES = 0x0004
}