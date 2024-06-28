using System.Diagnostics.CodeAnalysis;

namespace SDL_cs;

/// <summary>
/// SDL Audio Device instance IDs.
/// </summary>
/// <remarks>
/// This structure is a wrapper for a 32-bit unsigned integer. Refer to the official
/// <see href="https://wiki.libsdl.org/SDL3/SDL_AudioDeviceID">documentation</see> for more details.
/// </remarks>
[Typedef]
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
	/// Gets the numerical value of an <see cref="SDL_AudioDeviceId"/> structure.
	/// </summary>
	/// <param name="x">The <see cref="SDL_AudioDeviceId"/> to convert.</param>
	public static explicit operator uint(SDL_AudioDeviceId x) => x._value;

	/// <summary>
	/// Converts a 32-bit unsigned integer into an <see cref="SDL_AudioDeviceId"/> structure.
	/// </summary>
	/// <param name="x">The value to convert.</param>
	public static explicit operator SDL_AudioDeviceId(uint x) => new(x);

	/// <summary>
	/// Compares if two <see cref="SDL_AudioDeviceId"/> structures have the same numerical value.
	/// </summary>
	/// <param name="a">The <see cref="SDL_AudioDeviceId"/> at the left side of the comparison.</param>
	/// <param name="b">The <see cref="SDL_AudioDeviceId"/> at the right side of the comparison.</param>
	/// <returns>True if both <paramref name="a"/> and <paramref name="b"/> are the same, false otherwise.</returns>
	public static bool operator ==(SDL_AudioDeviceId a, SDL_AudioDeviceId b) => a._value == b._value;

	/// <summary>
	/// Compares if two <see cref="SDL_AudioDeviceId"/> structures don't have the same numerical value.
	/// </summary>
	/// <param name="a">The <see cref="SDL_AudioDeviceId"/> at the left side of the comparison.</param>
	/// <param name="b">The <see cref="SDL_AudioDeviceId"/> at the right side of the comparison.</param>
	/// <returns>True if both <paramref name="a"/> and <paramref name="b"/> are not the same, false otherwise.</returns>
	public static bool operator !=(SDL_AudioDeviceId a, SDL_AudioDeviceId b) => a._value != b._value;

	/// <summary>
	/// An invalid/null audio device ID. Used when a function that returns an <see cref="SDL_AudioDeviceId"/> fails.
	/// </summary>
	public static SDL_AudioDeviceId Invalid => new(0);

	private readonly uint _value;
}