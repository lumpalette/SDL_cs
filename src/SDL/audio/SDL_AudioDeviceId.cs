namespace SDL3;

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
	/// An invalid/null audio device ID.
	/// </summary>
	Invalid = 0
}