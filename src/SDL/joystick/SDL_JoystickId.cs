using System.Diagnostics.CodeAnalysis;

namespace SDL_cs;

/// <summary>
/// Represents a unique ID for a joystick.
/// </summary>
/// <remarks>
/// The structure is a wrapper for an unsigned 32-bit integer. Refer to the official documentation
/// <see href="https://wiki.libsdl.org/SDL3/SDL_JoystickID">here</see> for more details.
/// </remarks>
[Wrapper]
public readonly struct SDL_JoystickId
{
	internal SDL_JoystickId(uint value)
	{
		_value = value;
	}

	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj)
	{
		if (obj is SDL_JoystickId cast)
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

	public static explicit operator uint(SDL_JoystickId x) => x._value;

	public static explicit operator SDL_JoystickId(uint x) => new(x);

	public static bool operator ==(SDL_JoystickId a, SDL_JoystickId b) => a._value == b._value;

	public static bool operator !=(SDL_JoystickId a, SDL_JoystickId b) => a._value != b._value;

	/// <summary>
	/// An invalid ID for a joystick. Used when a function that returns an <see cref="SDL_JoystickId"/> fails.
	/// </summary>
	public static SDL_JoystickId Invalid => new(0);

	private readonly uint _value;
}