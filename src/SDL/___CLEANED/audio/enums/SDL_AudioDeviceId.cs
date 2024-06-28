using System.Diagnostics.CodeAnalysis;

namespace SDL_cs;

/// <summary>
/// SDL Audio Device instance IDs.
/// </summary>
/// <remarks>
/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AudioDeviceID">documentation</see> for more details.
/// </remarks>
[Typedef]
public enum SDL_AudioDeviceId : uint
{
	/// <summary>
	/// An invalid/null audio device ID. Used when a function that returns an <see cref="SDL_AudioDeviceId"/> fails.
	/// </summary>
	Invalid = 0
}