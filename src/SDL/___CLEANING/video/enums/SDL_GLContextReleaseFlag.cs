using System;

namespace SDL_cs;

/// <summary>
/// Possible values to be set for the <see cref="FIXME:SDL_GL_CONTEXT_RELEASE_BEHAVIOR"/> attribute.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GLcontextReleaseFlag">documentation</see> for more details.
/// </remarks>
[Flags]
public enum SDL_GLContextReleaseFlag
{
	None = 0x0000,
	Flush = 0x0001,
}