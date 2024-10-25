using System;

namespace SDL3;

/// <summary>
/// Possible flags to be set for the <see cref="SDL_GLAttr.ContextFlags"/> attribute.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GLContextFlag">documentation</see> for more details.
/// </remarks>
[Flags]
public enum SDL_GLContextFlag : uint
{
	ContextDebug = 0x0001,
	ContextForwardCompatible = 0x0002,
	ContextRobustAccess = 0x0004,
	ContextResetIsolation = 0x0008
}