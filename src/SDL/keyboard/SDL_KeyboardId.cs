using System.Diagnostics.CodeAnalysis;

namespace SDL_cs;

/// <summary>
/// This is a unique ID for a keyboard for the time it is connected to the system, and is never reused for the
/// lifetime of the application.
/// </summary>
/// <remarks>
/// This structure is a wrapper for an unsigned 32-bit integer. Refer to the official documentation
/// <see href="https://wiki.libsdl.org/SDL3/SDL_KeyboardID">here</see> for more details.
/// </remarks>
[Wrapper]
public readonly struct SDL_KeyboardId
{
	internal SDL_KeyboardId(uint value)
	{
		_value = value;
	}

	/// <inheritdoc/>
	public override bool Equals([NotNullWhen(true)] object? obj)
	{
		if (obj is SDL_KeyboardId cast)
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

	public static explicit operator uint(SDL_KeyboardId x) => x._value;

	public static explicit operator SDL_KeyboardId(uint x) => new(x);

	public static bool operator ==(SDL_KeyboardId a, SDL_KeyboardId b) => a._value == b._value;

	public static bool operator !=(SDL_KeyboardId a, SDL_KeyboardId b) => a._value != b._value;

	private readonly uint _value;
}