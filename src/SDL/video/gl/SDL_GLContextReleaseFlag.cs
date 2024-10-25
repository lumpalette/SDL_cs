using System;

namespace SDL3;

/// <summary>
/// Possible values to be set for the <see cref="SDL_GLAttr.ContextReleaseBehaviour"/> attribute.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_GLContextReleaseFlag">documentation</see> for more details.
/// </remarks>
[Flags]
public enum SDL_GLContextReleaseFlag : uint
{
	ContextReleaseBehaviourNone = 0x0000,
	ContextReleaseBehaviourFlush = 0x0001,
}