using System.Diagnostics.CodeAnalysis;

namespace SDL_cs;

/// <summary>
/// SDL Audio Device instance IDs.
/// </summary>
/// <remarks>
/// The structure is a wrapper for an unsigned 32-bit integer. Refer to the official documentation
/// <see href="https://wiki.libsdl.org/SDL3/SDL_AudioDeviceID">here</see> for more details.
/// </remarks>
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

	/// <summary>
	/// An invalid audio device ID. Used when a function that returns an <see cref="SDL_AudioDeviceId"/> fails.
	/// </summary>
	public static SDL_AudioDeviceId Invalid => new();

	public static explicit operator uint(SDL_AudioDeviceId x) => x._value;

	public static explicit operator SDL_AudioDeviceId(uint x) => new(x);

	public static bool operator ==(SDL_AudioDeviceId a, SDL_AudioDeviceId b) => a._value == b._value;

	public static bool operator !=(SDL_AudioDeviceId a, SDL_AudioDeviceId b) => a._value != b._value;

	private readonly uint _value;
}