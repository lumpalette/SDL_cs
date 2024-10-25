using System;

namespace SDL3;

/// <summary>
/// Possible values to be set <see cref="SDL_GLAttr.ContextResetNotification"/> attribute.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GLContextResetNotification">documentation</see> for more details.
/// </remarks>
[Flags]
public enum SDL_GLContextResetNotification : uint
{
	ContextResetNoNotification = 0x0000,
	ContextResetLoseContext = 0x0001,
}