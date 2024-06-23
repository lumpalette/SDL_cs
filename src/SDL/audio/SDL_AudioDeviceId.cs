using System.Diagnostics.CodeAnalysis;

namespace SDL_cs;

/// <summary>
/// SDL Audio Device instance IDs.
/// </summary>
/// <remarks>
/// This structure is a wrapper for an unsigned 32-bit integer. Refer to the official documentation
/// <see href="https://wiki.libsdl.org/SDL3/SDL_AudioDeviceID">here</see> for more details.
/// </remarks>
[Wrapper]
public readonly struct SDL_AudioDeviceId
{
	internal SDL_AudioDeviceId(uint value)
	{
		_value = value;
	}

	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj)
	{
		if (obj is SDL_AudioDeviceId cast)
		{
			return _value == cast._value;
		}
		return false;
	}

	/// <inheritdoc/>
	public override int GetHashCode()
	{
		return _value.GetHashCode();
	}

	public static explicit operator uint(SDL_AudioDeviceId x) => x._value;

	public static explicit operator SDL_AudioDeviceId(uint x) => new(x);

	public static bool operator ==(SDL_AudioDeviceId a, SDL_AudioDeviceId b) => a._value == b._value;

	public static bool operator !=(SDL_AudioDeviceId a, SDL_AudioDeviceId b) => a._value != b._value;

	/// <summary>
	/// An invalid audio device ID. Used when a function that returns an <see cref="SDL_AudioDeviceId"/> fails.
	/// </summary>
	public static SDL_AudioDeviceId Invalid => new(0);

	/// <summary>
	/// A value used to request a default playback audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_AUDIO_DEVICE_DEFAULT_PLAYBACK">here</see> for more details.
	/// </remarks>
	public static SDL_AudioDeviceId DefaultPlayback => new(0xFFFFFFFF);

	/// <summary>
	/// A value used to request a default recording audio device.
	/// </summary>
	/// <remarks>
	/// Refer to the official documentation <see href="https://wiki.libsdl.org/SDL3/SDL_AUDIO_DEVICE_DEFAULT_RECORDING">here</see> for more details.
	/// </remarks>
	public static SDL_AudioDeviceId DefaultRecording => new(0xFFFFFFFE);

	private readonly uint _value;
}