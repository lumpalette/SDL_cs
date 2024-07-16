using System;

namespace SDL_cs;

/// <summary>
/// Possible values to be set <see cref="FIXME:SDL_GL_CONTEXT_RESET_NOTIFICATION"/> attribute.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GLContextResetNotification">documentation</see> for more details.
/// </remarks>
[Flags]
public enum SDL_GLContextResetNotification
{
	NoNotification = 0x0000,
	LoseContext = 0x0001,
}