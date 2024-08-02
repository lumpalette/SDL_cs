using System;

namespace SDL3;

/// <summary>
/// Possible values to be set for the <see cref="FIXME:SDL_GL_CONTEXT_FLAGS"/> attribute.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GLcontextFlag">documentation</see> for more details.
/// </remarks>
[Flags]
public enum SDL_GLContextFlag
{
	Debug = 0x0001,
	ForwardCompatible = 0x0002,
	RobustAccess = 0x0004,
	ResetIsolation = 0x0008
}