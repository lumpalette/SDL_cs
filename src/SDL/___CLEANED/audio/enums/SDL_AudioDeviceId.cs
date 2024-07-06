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
	/// An invalid/null audio device ID.
	/// </summary>
	Invalid = 0,

	/// <summary>
	/// A value used to request a default playback audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AUDIO_DEVICE_DEFAULT_PLAYBACK">documentation</see> for more details.
	/// </remarks>
	DefaultPlayback = 0xFFFFFFFF,

	/// <summary>
	/// A value used to request a default recording audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official <see href="https://wiki.libsdl.org/SDL3/SDL_AUDIO_DEVICE_DEFAULT_RECORDING">documentation</see> for more details.
	/// </remarks>
	DefaultRecording = 0xFFFFFFFE,
}